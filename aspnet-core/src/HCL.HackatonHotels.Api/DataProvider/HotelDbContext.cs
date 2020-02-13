namespace HCl.Hotel.Api.DataProvider
{
    using System.Reflection;
    using HCl.Hotel.Api.DataProvider.Mapping;
    using Microsoft.EntityFrameworkCore;

    namespace ProductService.DataProvider
    {
        public class HotelDbContext : DbContext
        {
            public HotelDbContext(DbContextOptions<HotelDbContext> options) : base(options)
            {
            }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                //optionsBuilder.UseLazyLoadingProxies();
                base.OnConfiguring(optionsBuilder);
            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.ApplyConfiguration(new BookMappingConfiguration());
                modelBuilder.ApplyConfiguration(new HotelMappingConfiguration());
                modelBuilder.ApplyConfiguration(new HotelMappingConfiguration());
                modelBuilder.ApplyConfiguration(new RoomMappingConfiguration());
            }
        }
    }
}
