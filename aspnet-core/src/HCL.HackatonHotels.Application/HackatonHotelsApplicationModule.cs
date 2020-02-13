using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using HCL.HackatonHotels.Authorization;

namespace HCL.HackatonHotels
{
    [DependsOn(
        typeof(HackatonHotelsCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class HackatonHotelsApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<HackatonHotelsAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(HackatonHotelsApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
