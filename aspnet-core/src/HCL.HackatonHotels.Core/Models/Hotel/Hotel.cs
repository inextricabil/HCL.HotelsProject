using System.Collections.Generic;

namespace HCL.HackatonHotels.Core.Models.Hotel
{
    public class Hotel
    {
        public Hotel()
        {
            this.Rooms = new List<Room>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public long LocationId { get; set; }

        public Location Location { get; set; }

        public virtual ICollection<Room> Rooms { get; set; }
    }


}
