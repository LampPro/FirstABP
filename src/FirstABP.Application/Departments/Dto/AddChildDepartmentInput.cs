using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstABP.Departments.Dto
{
    public class AddChildDepartmentInput :  IValidatableObject

    {
        [Required]
        public Guid ParentDepartmentId
        {
            get;
            set;
        }

        [Required]
        public Guid ChildDepartmentId
        {
            get;
            set;
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (ParentDepartmentId.Equals(ChildDepartmentId))
            {
                yield return new ValidationResult("Department can not add itself as a child department!");             
            }
        }
    }
}
