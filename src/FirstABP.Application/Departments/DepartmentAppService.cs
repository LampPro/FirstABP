using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.IdentityFramework;
using FirstABP.Authorization;
using FirstABP.Departments.Dto;
using FirstABP.Entities;
using FirstABP.IManager;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FirstABP.Departments
{
    //[AbpAuthorize(PermissionNames.Pages_Departments)]
    public class DepartmentAppService : AsyncCrudAppService<Department, DepartmentDto, Guid, PagedResultRequestDto, CreateDepartmentDto, DepartmentDto>, IDepartmentAppService
    {
        private readonly IDepartmentManager _departmentManager;
        private readonly IRepository<Department, Guid> _departmentRepository;


        public DepartmentAppService(IRepository<Department, Guid> repository, IDepartmentManager departmentManager, IRepository<Department, Guid> departmentRepository) : base(repository)
        {
            this._departmentManager = departmentManager;
            this._departmentRepository = departmentRepository;
        }

        public override async Task<DepartmentDto> Create(CreateDepartmentDto input)
        {
            CheckCreatePermission();

            var department = ObjectMapper.Map<Department>(input);


            await _departmentRepository.InsertAsync(department);

            if (input.ParentDepartmentId.HasValue)
            {
                var parent = await _departmentRepository.GetAsync(input.ParentDepartmentId.Value);
                _departmentManager.AddChildDepartment(parent, department);
            }

            return MapToEntityDto(department);
        }

        public async Task AddChildDepartmentAsync(AddChildDepartmentInput input)
        {
            Department parent = await _departmentRepository.GetAsync(input.ParentDepartmentId);
            Department child = await _departmentRepository.GetAsync(input.ChildDepartmentId);
            _departmentManager.AddChildDepartment(parent, child);
        }
    }
}
