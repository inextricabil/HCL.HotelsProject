using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.EntityFrameworkCore;
using HCL.HackatonHotels.Controllers;
using HCL.HackatonHotels.Core.Models.Hotel;
using HCL.HackatonHotels.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HCL.HackatonHotels.Web.Host.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelsController : HackatonHotelsControllerBase
    {
        private readonly HackatonHotelsDbContext _context;

        public HotelsController(IDbContextProvider<HackatonHotelsDbContext> dbContextProvider)
        {
            this._context = dbContextProvider.GetDbContext();
        }

        // GET: api/Hotels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Hotel>>> GetHotels()
        {
            return await this._context.Hotels.ToListAsync();
        }

        // GET: api/Hotels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Hotel>> GetHotel(long id)
        {
            Hotel hotel = await this._context.Hotels.FindAsync(id);

            if (hotel == null)
            {
                return this.NotFound();
            }

            return hotel;
        }

        // PUT: api/Hotels/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHotel(long id, Hotel hotel)
        {
            if (id != hotel.Id)
            {
                return this.BadRequest();
            }

            this._context.Entry(hotel).State = EntityState.Modified;

            try
            {
                await this._context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!this.HotelExists(id))
                {
                    return this.NotFound();
                }
                else
                {
                    throw;
                }
            }

            return this.NoContent();
        }

        // POST: api/Hotels
        [HttpPost]
        public async Task<ActionResult<Hotel>> PostHotel(Hotel hotel)
        {
            this._context.Hotels.Add(hotel);
            await this._context.SaveChangesAsync();

            return this.CreatedAtAction("GetHotel", new { id = hotel.Id }, hotel);
        }

        // DELETE: api/Hotels/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Hotel>> DeleteHotel(long id)
        {
            Hotel hotel = await this._context.Hotels.FindAsync(id);
            if (hotel == null)
            {
                return this.NotFound();
            }

            this._context.Hotels.Remove(hotel);
            await this._context.SaveChangesAsync();

            return hotel;
        }

        private bool HotelExists(long id)
        {
            return this._context.Hotels.Any(e => e.Id == id);
        }
    }
}
