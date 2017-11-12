using Abp.Application.Services;
using Abp.Application.Services.Dto;
using FirstABP.Departments.Dto;
using FirstABP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstABP.Departments
{
    public interface IDepartmentAppService : IAsyncCrudAppService<DepartmentDto, Guid, PagedResultRequestDto, CreateDepartmentDto, DepartmentDto>
    {
        Task AddChildDepartmentAsync(AddChildDepartmentInput input);
    }
}
