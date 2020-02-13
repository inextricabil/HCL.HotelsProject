using HCL.HackatonHotels.Core.Models.Hotel;
using System;
using System.Collections.Generic;
using System.Text;

namespace HCL.HackatonHotels.Roles.Dto
{
    public class ClientDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public long LocationId { get; set; }

        public Location Location { get; set; }
    }
}
