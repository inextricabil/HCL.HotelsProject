using System.Collections.Generic;

namespace HCl.Hotel.Api.DataProvider.Models
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
