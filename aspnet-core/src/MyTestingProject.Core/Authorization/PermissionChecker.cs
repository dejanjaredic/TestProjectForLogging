using Abp.Authorization;
using MyTestingProject.Authorization.Roles;
using MyTestingProject.Authorization.Users;

namespace MyTestingProject.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
