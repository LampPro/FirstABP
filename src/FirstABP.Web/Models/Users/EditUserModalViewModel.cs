using System.Collections.Generic;
using System.Linq;
using FirstABP.Roles.Dto;
using FirstABP.Users.Dto;

namespace FirstABP.Web.Models.Users
{
    public class EditUserModalViewModel
    {
        public UserDto User { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }

        public bool UserIsInRole(RoleDto role)
        {
            return User.Roles != null && User.Roles.Any(r => r == role.DisplayName);
        }
    }
}