using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using HCL.HackatonHotels.Authorization.Roles;
using HCL.HackatonHotels.Authorization.Users;
using HCL.HackatonHotels.MultiTenancy;

namespace HCL.HackatonHotels.EntityFrameworkCore
{
    public class HackatonHotelsDbContext : AbpZeroDbContext<Tenant, Role, User, HackatonHotelsDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public HackatonHotelsDbContext(DbContextOptions<HackatonHotelsDbContext> options)
            : base(options)
        {
        }
    }
}
