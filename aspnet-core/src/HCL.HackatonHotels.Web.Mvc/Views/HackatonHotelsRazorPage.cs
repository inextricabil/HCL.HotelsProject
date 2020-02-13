using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace HCL.HackatonHotels.Web.Views
{
    public abstract class HackatonHotelsRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected HackatonHotelsRazorPage()
        {
            LocalizationSourceName = HackatonHotelsConsts.LocalizationSourceName;
        }
    }
}
