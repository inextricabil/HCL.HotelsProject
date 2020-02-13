using Abp.Authorization;
using HCL.HackatonHotels.Authorization.Roles;
using HCL.HackatonHotels.Authorization.Users;

namespace HCL.HackatonHotels.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
