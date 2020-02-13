using System;

namespace HCL.HackatonHotels.Core.Models.Hotel
{
    public class BookedRoom
    {
        public long Id { get; set; }

        public long RoomId { get; set; }

        public Room Room { get; set; }

        public long ClientId { get; set; }

        public Client Client { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}
