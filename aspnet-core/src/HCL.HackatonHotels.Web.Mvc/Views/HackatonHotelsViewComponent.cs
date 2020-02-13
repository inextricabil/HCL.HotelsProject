using Abp.AspNetCore.Mvc.ViewComponents;

namespace HCL.HackatonHotels.Web.Views
{
    public abstract class HackatonHotelsViewComponent : AbpViewComponent
    {
        protected HackatonHotelsViewComponent()
        {
            LocalizationSourceName = HackatonHotelsConsts.LocalizationSourceName;
        }
    }
}
