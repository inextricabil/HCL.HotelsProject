using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace HCL.HackatonHotels.Controllers
{
    public abstract class HackatonHotelsControllerBase: AbpController
    {
        protected HackatonHotelsControllerBase()
        {
            LocalizationSourceName = HackatonHotelsConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
