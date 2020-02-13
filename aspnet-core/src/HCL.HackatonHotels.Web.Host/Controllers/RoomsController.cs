using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using HCL.HackatonHotels.Controllers;
using HCL.HackatonHotels.Core.Models.Hotel;
using Microsoft.AspNetCore.Mvc;

namespace HCL.HackatonHotels.Web.Host.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomsController : HackatonHotelsControllerBase
    {
        private readonly IRepository<Room> _repository;

        public RoomsController(IRepository<Room> repository)
        {
            this._repository = repository;
        }

        // GET: api/Rooms
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Room>>> GetRooms()
        {
            //return await this._repository.GetAllListAsync();

            return new List<Room>
            {
                new Room
                {
                    Id = 1,
                    Description = "Nice room with 2 separate beds",
                    HotelId = 1,
                    Price = 150,
                    RoomNumber = 10,
                    Type = RoomType.Single,
                    IsActive = true
                },
                new Room
                {
                    Id = 2,
                    Description = "Good room with 3 beds",
                    HotelId = 1,
                    Price = 100,
                    RoomNumber = 11,
                    Type = RoomType.Double,
                    IsActive = false
                },
                new Room
                {
                    Id = 3,
                    Description = "Grand Suite",
                    HotelId = 1,
                    Price = 500,
                    RoomNumber = 12,
                    Type = RoomType.Double,
                    IsActive = true
                }
            };
        }

        // GET: api/Rooms/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Room>> GetRoom(int id)
        {
            Room room = await this._repository.GetAsync(id);

            if (room == null)
            {
                return this.NotFound();
            }

            return room;
        }

        // PUT: api/Rooms/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Room>> PutRoom(int id, Room room)
        {
            if (id != room.Id)
            {
                return this.BadRequest();
            }

            return await this._repository.UpdateAsync(room);
        }

        // POST: api/Rooms
        [HttpPost]
        public async Task<ActionResult<Room>> PostRoom(Room room)
        {
            int id = await this._repository.InsertAndGetIdAsync(room);

            return this.CreatedAtAction("GetRoom", new { id }, room);
        }

        // DELETE: api/Rooms/5
        [HttpDelete("{id}")]
        public IActionResult DeleteRoom(int id)
        {
            this._repository.Delete(id);

            return this.Ok();
        }
    }
}
