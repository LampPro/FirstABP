using Abp.Application.Services.Dto;
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
    [AutoMapFrom(typeof(Department))]
    public class DepartmentDto : EntityDto<Guid>
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

        public List<DepartmentDto> ChildDepartment
        {
            get;
            protected set;
        }
    }
}
