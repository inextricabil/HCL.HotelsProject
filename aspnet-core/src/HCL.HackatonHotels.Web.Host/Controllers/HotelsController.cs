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
    public class HotelsController : HackatonHotelsControllerBase
    {
        private readonly IRepository<Hotel> _repository;

        public HotelsController(IRepository<Hotel> repository)
        {
            this._repository = repository;
        }

        // GET: api/Hotels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Hotel>>> GetHotels()
        {
            return await this._repository.GetAllListAsync();
        }

        // GET: api/Hotels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Hotel>> GetHotel(int id)
        {
            Hotel hotel = await this._repository.GetAsync(id);

            if (hotel == null)
            {
                return this.NotFound();
            }

            return hotel;
        }

        // PUT: api/Hotels/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Hotel>> PutHotel(int id, Hotel hotel)
        {
            if (id != hotel.Id)
            {
                return this.BadRequest();
            }

            return await this._repository.UpdateAsync(hotel);
        }

        // POST: api/Hotels
        [HttpPost]
        public async Task<ActionResult<Hotel>> PostHotel(Hotel hotel)
        {
            int id = await this._repository.InsertAndGetIdAsync(hotel);

            return this.CreatedAtAction("GetHotel", new { id }, hotel);
        }

        // DELETE: api/Hotels/5
        [HttpDelete("{id}")]
        public IActionResult DeleteHotel(int id)
        {
            this._repository.Delete(id);

            return this.Ok();
        }
    }
}
