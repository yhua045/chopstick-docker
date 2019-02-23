using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ChopstickDocker.Configuration;
using ChopstickDocker.Web;

namespace ChopstickDocker.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ChopstickDockerDbContextFactory : IDesignTimeDbContextFactory<ChopstickDockerDbContext>
    {
        public ChopstickDockerDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ChopstickDockerDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ChopstickDockerDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ChopstickDockerConsts.ConnectionStringName));

            return new ChopstickDockerDbContext(builder.Options);
        }
    }
}
