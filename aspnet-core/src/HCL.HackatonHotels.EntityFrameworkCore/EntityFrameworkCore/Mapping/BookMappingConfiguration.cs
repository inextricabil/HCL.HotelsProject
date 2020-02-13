using HCL.HackatonHotels.Core.Models.Hotel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HCL.HackatonHotels.EntityFrameworkCore.Mapping
{
    public class BookMappingConfiguration : IEntityTypeConfiguration<BookedRoom>
    {
        public void Configure(EntityTypeBuilder<BookedRoom> builder)
        {
            builder.ToTable("BookedRooms");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).UseSqlServerIdentityColumn();

            builder.Property(c => c.StartDate);

            builder.Property(c => c.EndDate);

            builder.Property(c => c.RoomId);

            builder.Property(c => c.ClientId);

            builder.HasOne(c => c.Room)
                .WithMany(x => x.Books)
                .HasForeignKey(x => x.RoomId);
        }
    }
}
