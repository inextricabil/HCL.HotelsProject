using System;
using System.Collections.Generic;

namespace HCL.HackatonHotels.Web.Core.Models.Hotel
{
    public class Room
    {
        public Room()
        {
            this.Books = new List<BookedRoom>();
        }

        public long Id { get; set; }

        public int RoomNumber { get; set; }

        public RoomType Type { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public long HotelId { get; set; }

        public Hotel Hotel { get; set; }

        public ICollection<BookedRoom> Books { get; set; }
    }
}