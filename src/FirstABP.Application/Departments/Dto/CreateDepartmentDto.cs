using Abp.AutoMapper;
using FirstABP.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstABP.Departments.Dto
{
    [AutoMapTo(typeof(Department))]
    public class CreateDepartmentDto
    {
        [Required]
        public string Name
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set;
        }

        public string CostCenter
        {
            get;
            set;
        }

        public Guid? ParentDepartmentId
        {
            get;
            set;
        }
    }
}
