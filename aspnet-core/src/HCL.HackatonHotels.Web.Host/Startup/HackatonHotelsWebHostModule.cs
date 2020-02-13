using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using HCL.HackatonHotels.Configuration;

namespace HCL.HackatonHotels.Web.Host.Startup
{
    [DependsOn(
       typeof(HackatonHotelsWebCoreModule))]
    public class HackatonHotelsWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public HackatonHotelsWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(HackatonHotelsWebHostModule).GetAssembly());
        }
    }
}
