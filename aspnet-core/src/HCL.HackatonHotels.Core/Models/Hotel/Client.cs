using Abp.Domain.Entities;

namespace HCL.HackatonHotels.Core.Models.Hotel
{
    public class Client : IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public bool IsTransient()
        {
            return true;
        }
    }
}