using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstABP.Entities;
using Abp.Domain.Repositories;

namespace FirstABP.IRepositories
{
    public interface IDepartmentRepository: IRepository<Department,Guid>
    {
    }
}
