﻿namespace HCL.HackatonHotels.Roles.Dto
{
    public class RoomDto
    {

        public int Id { get; set; }

        public int RoomNumber { get; set; }

        public string Type { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public long HotelId { get; set; }

        public bool IsActive { get; set; }


    }

    public enum RoomType
    {
        Single,
        Double,
    }
}
