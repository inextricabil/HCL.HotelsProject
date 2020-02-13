using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HCl.Hotel.Api.DataProvider.Mapping
{
    public class LocationMappingConfiguration : IEntityTypeConfiguration<Models.Location>
    {
        public void Configure(EntityTypeBuilder<Models.Location> builder)
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
