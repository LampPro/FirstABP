using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using FirstABP.ValueObjects;

namespace FirstABP.Entities
{
    public class UserExtend : FullAuditedEntity<Guid>,IMustHaveTenant
    {
        public int TenantId
        {
            get;
            set;
        }
        public virtual Department Department
        {
            get;
            set;
        }

        public virtual Address Address
        {
            get;
            set;
        }
    }
}
