using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HCL.HackatonHotels.Controllers;
using HCL.HackatonHotels.Roles.Dto;
using HCL.HackatonHotels.Users;
using HCL.HackatonHotels.Users.Dto;
using HCL.HackatonHotels.Web.Models.Users;
using Microsoft.AspNetCore.Mvc;

namespace HCL.HackatonHotels.Web.Mvc.Controllers
{
    public class RoomsController : HackatonHotelsControllerBase
    {
        private readonly IUserAppService _userAppService;

        public RoomsController(IUserAppService userAppService)
        {
            _userAppService = userAppService;
        }

        public async Task<IActionResult> Index()
        {
            var users = (await _userAppService.GetAll(new PagedUserResultRequestDto { MaxResultCount = int.MaxValue })).Items; // Paging not implemented yet
            var roles = (await _userAppService.GetRoles()).Items;

            var rooms = new List<RoomDto>
            {
                new RoomDto
                {
                    Id = Guid.NewGuid(),
                       Description = "Nice room with 2 separate beds",
                       HotelId = 1,
                       Price = 150,
                       RoomNumber = 10,
                       Type = "Single room",
                       IsActive = true
                },
                 new RoomDto
                {
                    Id = Guid.NewGuid(),
                       Description = "Good room with 3 beds",
                       HotelId = 1,
                       Price = 100,
                       RoomNumber = 11,
                       Type = "Triple room",
                       IsActive = false
                },
                  new RoomDto
                {
                    Id = Guid.NewGuid(),
                       Description = "Grand Suite",
                       HotelId = 1,
                       Price = 500,
                       RoomNumber = 12,
                       Type = "5 beds room",
                       IsActive = true
                }
            };
            var model = new UserListViewModel
            {
                Users = users,
                Roles = roles,
                Rooms = rooms
            };
            return View(model);
        }
    }
}