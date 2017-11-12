using System.Collections.Generic;
using FirstABP.Roles.Dto;
using FirstABP.Users.Dto;

namespace FirstABP.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}