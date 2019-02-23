using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ChopstickDocker.EntityFrameworkCore
{
    public static class ChopstickDockerDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ChopstickDockerDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ChopstickDockerDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
