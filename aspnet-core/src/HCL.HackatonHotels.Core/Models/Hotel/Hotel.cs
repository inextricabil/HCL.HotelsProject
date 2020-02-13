using System.Collections.Generic;
using Abp.Domain.Entities;

namespace HCL.HackatonHotels.Core.Models.Hotel
{
    public class Hotel : IEntity
    {
        public Hotel()
        {
            this.Rooms = new List<Room>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int LocationId { get; set; }

        public Location Location { get; set; }

        public virtual ICollection<Room> Rooms { get; set; }

        public bool IsTransient()
        {
            return true;
        }
    }


}
