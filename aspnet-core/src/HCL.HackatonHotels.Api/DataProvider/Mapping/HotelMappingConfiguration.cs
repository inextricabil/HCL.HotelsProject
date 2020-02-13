using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HCl.Hotel.Api.DataProvider.Mapping
{
    public class HotelMappingConfiguration : IEntityTypeConfiguration<Models.Hotel>
    {
        public void Configure(EntityTypeBuilder<Models.Hotel> builder)
        {
            builder.ToTable("Hotels");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).UseSqlServerIdentityColumn();
            builder.Property(c => c.Name).HasMaxLength(200);
            builder.Property(c => c.Description);
            builder.Property(c => c.LocationId);

            builder.HasOne(c => c.Location)
                .WithMany(x => x.Hotels)
                .HasForeignKey(x => x.LocationId);
        }
    }
}
