using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ChopstickDocker.Authorization.Roles;
using ChopstickDocker.Authorization.Users;
using ChopstickDocker.MultiTenancy;

namespace ChopstickDocker.EntityFrameworkCore
{
    public class ChopstickDockerDbContext : AbpZeroDbContext<Tenant, Role, User, ChopstickDockerDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ChopstickDockerDbContext(DbContextOptions<ChopstickDockerDbContext> options)
            : base(options)
        {
        }
    }
}
