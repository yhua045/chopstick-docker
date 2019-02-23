using Abp.Authorization;
using ChopstickDocker.Authorization.Roles;
using ChopstickDocker.Authorization.Users;

namespace ChopstickDocker.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
