using System.Collections.Generic;
using Abp.Domain.Entities;

namespace HCL.HackatonHotels.Core.Models.Hotel
{
    public class Location : IEntity
    {
        public int Id { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public string Street { get; set; }

        public string StreetDetails { get; set; }

        public string PostalCode { get; set; }

        public ICollection<Hotel> Hotels { get; set; }

        public bool IsTransient()
        {
            return true;
        }
    }
}