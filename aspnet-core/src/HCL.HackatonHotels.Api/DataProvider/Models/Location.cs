using System.Collections.Generic;

namespace HCl.Hotel.Api.DataProvider.Models
{
    public class Location
    {
        public long Id { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public string Street { get; set; }

        public string StreetDetails { get; set; }

        public string PostalCode { get; set; }

        public ICollection<Hotel> Hotels { get; set; }
    }
}