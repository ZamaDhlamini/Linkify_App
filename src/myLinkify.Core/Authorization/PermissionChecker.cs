using Abp.Authorization;
using myLinkify.Authorization.Roles;
using myLinkify.Authorization.Users;

namespace myLinkify.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
