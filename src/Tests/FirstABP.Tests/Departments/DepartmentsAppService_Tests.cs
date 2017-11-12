using FirstABP.Departments;
using FirstABP.Departments.Dto;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Shouldly;

namespace FirstABP.Tests.Departments
{
    public class DepartmentsAppService_Tests : FirstABPTestBase
    {
        private readonly IDepartmentAppService _departmentAppService;

        public DepartmentsAppService_Tests()
        {
            _departmentAppService = Resolve<IDepartmentAppService>();
        }

        //[Fact]
        //public async Task CreateDepartment_Test()
        //{
        //    await _departmentAppService.Create(
        //        new CreateDepartmentDto
        //        {
        //            Name = "IT",
        //            Description = "IT",
        //            CostCenter = "1234"
        //        });

        //    await UsingDbContextAsync(async context =>
        //    {
        //        var itDepart = await context.Departments.FirstOrDefaultAsync(d => d.Name == "IT");
        //        itDepart.ShouldNotBeNull();
        //    });
        //}

        [Fact]
        public async Task Should_Create_New_Department_And_Add_Child_Department()
        {
            await _departmentAppService.Create(
                new CreateDepartmentDto
                {
                    Name = "IT",
                    Description = "IT",
                    CostCenter = "1234"
                });

            await _departmentAppService.Create(
                new CreateDepartmentDto
                {
                    Name = "Soft",
                    Description = "Soft",
                    CostCenter = "1234"
                });

            await UsingDbContextAsync(async context =>
            {
                var itDepart = await context.Departments.FirstOrDefaultAsync(d => d.Name == "IT");

                var softDepart = await context.Departments.FirstOrDefaultAsync(d => d.Name == "Soft");
                itDepart.ShouldNotBeNull();
                softDepart.ShouldNotBeNull();

                await _departmentAppService.AddChildDepartmentAsync(new AddChildDepartmentInput
                {
                    ParentDepartmentId = itDepart.Id,
                    ChildDepartmentId = softDepart.Id
                });

                softDepart = await context.Departments.FirstOrDefaultAsync(d => d.Name == "Soft");

                softDepart.ParentDepartment.Id.ShouldBe(itDepart.Id);
            });
        }
    }
}
