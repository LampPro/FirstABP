using Abp.Domain.Services;
using FirstABP.Authorization.Users;
using FirstABP.Entities;
using FirstABP.IManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstABP.Manager
{
    public class DepartmentManager : DomainService, IDepartmentManager
    {
        public void AddChildDepartment(Department department, Department childDepartment)
        {
            childDepartment.SetParentDepartment(department);
            department.ChildDepartments.Add(childDepartment);
        }
    }
}
