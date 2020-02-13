using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HCl.Hotel.Api.DataProvider.Mapping
{
    public class RoomMappingConfiguration : IEntityTypeConfiguration<Models.Room>
    {
        public void Configure(EntityTypeBuilder<Models.Room> builder)
        {
            builder.ToTable("Rooms");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).UseSqlServerIdentityColumn();
            builder.Property(c => c.RoomNumber).HasMaxLength(200);
            builder.Property(c => c.Type);
            builder.Property(c => c.Description);
            builder.Property(c => c.Price);

            builder.Property(c => c.HotelId);


            builder.HasOne(c => c.Hotel)
                .WithMany(x => x.Rooms)
                .HasForeignKey(x => x.HotelId);
        }
    }
}
