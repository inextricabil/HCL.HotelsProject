using System.Collections.Generic;
using Abp.Domain.Entities;

namespace HCL.HackatonHotels.Core.Models.Hotel
{
    public class Room : IEntity
    {
        public Room()
        {
            this.Books = new List<BookedRoom>();
        }

        public int Id { get; set; }

        public int RoomNumber { get; set; }

        public RoomType Type { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public int HotelId { get; set; }

        public Hotel Hotel { get; set; }

        public ICollection<BookedRoom> Books { get; set; }
        public bool IsActive { get; set; }

        public bool IsTransient()
        {
            return true;
        }
    }
}