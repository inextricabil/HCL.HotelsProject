using Abp.Zero.EntityFrameworkCore;
using HCL.HackatonHotels.Authorization.Roles;
using HCL.HackatonHotels.Authorization.Users;
using HCL.HackatonHotels.Core.Models.Hotel;
using HCL.HackatonHotels.EntityFrameworkCore.Mapping;
using HCL.HackatonHotels.MultiTenancy;
using Microsoft.EntityFrameworkCore;

namespace HCL.HackatonHotels.EntityFrameworkCore
{
    public class HackatonHotelsDbContext : AbpZeroDbContext<Tenant, Role, User, HackatonHotelsDbContext>
    {
        /* Define a DbSet for each entity of the application */

        public HackatonHotelsDbContext(DbContextOptions<HackatonHotelsDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BookMappingConfiguration());
            modelBuilder.ApplyConfiguration(new LocationMappingConfiguration());
            modelBuilder.ApplyConfiguration(new HotelMappingConfiguration());
            modelBuilder.ApplyConfiguration(new RoomMappingConfiguration());

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<BookedRoom> BookedRooms { get; set; }

    }
}
