using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using HCL.HackatonHotels.Configuration;

namespace HCL.HackatonHotels.Web.Startup
{
    [DependsOn(typeof(HackatonHotelsWebCoreModule))]
    public class HackatonHotelsWebMvcModule : AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public HackatonHotelsWebMvcModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Navigation.Providers.Add<HackatonHotelsNavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(HackatonHotelsWebMvcModule).GetAssembly());
        }
    }
}
