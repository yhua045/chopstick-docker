using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ChopstickDocker.Configuration;

namespace ChopstickDocker.Web.Host.Startup
{
    [DependsOn(
       typeof(ChopstickDockerWebCoreModule))]
    public class ChopstickDockerWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ChopstickDockerWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ChopstickDockerWebHostModule).GetAssembly());
        }
    }
}
