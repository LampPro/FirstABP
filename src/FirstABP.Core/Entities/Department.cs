using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using FirstABP.Authorization.Users;

namespace FirstABP.Entities
{
    public class Department : FullAuditedEntity<Guid>, IMustHaveTenant
    {
        public int TenantId
        {
            get;
            set;
        }

        [Required]
        public virtual string Name
        {
            get;
            set;
        }

        public virtual string Description
        {
            get;
            set;
        }

        public virtual string CostCenter
        {
            get;
            set;
        }

        public virtual Department ParentDepartment
        {
            get;
            set;
        }

        public virtual ICollection<Department> ChildDepartments
        {
            get;
            protected set;
        }

        public virtual ICollection<User> Users
        {
            get;
            protected set;
        }

        public virtual void SetParentDepartment(Department parentDepartment)
        {
            this.ParentDepartment = parentDepartment;
        }
    }
}
