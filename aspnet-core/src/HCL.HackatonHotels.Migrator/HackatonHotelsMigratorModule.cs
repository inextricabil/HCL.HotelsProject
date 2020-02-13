using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using HCL.HackatonHotels.Configuration;
using HCL.HackatonHotels.EntityFrameworkCore;
using HCL.HackatonHotels.Migrator.DependencyInjection;

namespace HCL.HackatonHotels.Migrator
{
    [DependsOn(typeof(HackatonHotelsEntityFrameworkModule))]
    public class HackatonHotelsMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public HackatonHotelsMigratorModule(HackatonHotelsEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(HackatonHotelsMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                HackatonHotelsConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(HackatonHotelsMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
