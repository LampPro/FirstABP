using Abp.Authorization;
using FirstABP.Authorization.Roles;
using FirstABP.Authorization.Users;

namespace FirstABP.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
