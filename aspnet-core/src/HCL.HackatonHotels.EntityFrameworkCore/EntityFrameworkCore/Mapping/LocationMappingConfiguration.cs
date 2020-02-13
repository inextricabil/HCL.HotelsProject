using HCL.HackatonHotels.Core.Models.Hotel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HCL.HackatonHotels.EntityFrameworkCore.Mapping
{
    public class LocationMappingConfiguration : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder.ToTable("Locations");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).UseSqlServerIdentityColumn();

            builder.Property(c => c.Country);
            builder.Property(c => c.City);
            builder.Property(c => c.Street);
            builder.Property(c => c.StreetDetails);
        }
    }
}
