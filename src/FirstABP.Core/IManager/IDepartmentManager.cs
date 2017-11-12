using Abp.Domain.Services;
using FirstABP.Authorization.Users;
using FirstABP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstABP.IManager
{
    public interface IDepartmentManager : IDomainService
    {
        void AddChildDepartment(Department department, Department childDepartment);
    }
}
