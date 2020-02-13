using System;
using Abp.Domain.Entities;

namespace HCL.HackatonHotels.Core.Models.Hotel
{
    public class BookedRoom : IEntity
    {
        public int Id { get; set; }

        public int RoomId { get; set; }

        public Room Room { get; set; }

        public int ClientId { get; set; }

        public Client Client { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public bool IsTransient()
        {
            return true;
        }
    }
}
