using HCL.HackatonHotels.Core.Models.Hotel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HCL.HackatonHotels.EntityFrameworkCore.Mapping
{
    public class HotelMappingConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
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
