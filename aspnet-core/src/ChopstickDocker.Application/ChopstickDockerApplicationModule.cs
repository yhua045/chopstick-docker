using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ChopstickDocker.Authorization;

namespace ChopstickDocker
{
    [DependsOn(
        typeof(ChopstickDockerCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ChopstickDockerApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ChopstickDockerAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ChopstickDockerApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
