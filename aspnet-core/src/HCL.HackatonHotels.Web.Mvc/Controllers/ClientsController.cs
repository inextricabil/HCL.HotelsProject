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
    public class ClientsController : HackatonHotelsControllerBase
    {
        private readonly IUserAppService _userAppService;

        public ClientsController(IUserAppService userAppService)
        {
            _userAppService = userAppService;
        }

        public async Task<IActionResult> Index()
        {
            var users = (await _userAppService.GetAll(new PagedUserResultRequestDto { MaxResultCount = int.MaxValue })).Items; // Paging not implemented yet
            var roles = (await _userAppService.GetRoles()).Items;

            var clients = new List<ClientDto>
            {
                new ClientDto
                {
                    Id = Guid.NewGuid(),
                    Description = "-",
                    Name = "Alexandra",
                    Location = new HackatonHotels.Core.Models.Hotel.Location
                    {
                        City = "Iasi",
                        Country="Romania",
                        PostalCode = "700703",
                        Street = "Baza 3"
                    }
                },
                new ClientDto
                {
                    Id = Guid.NewGuid(),
                    Description = "-",
                    Name = "Alex",
                    Location = new HackatonHotels.Core.Models.Hotel.Location
                    {
                        City = "Iasi",
                        Country="Romania",
                        PostalCode = "700703",
                        Street = "Baza 3"
                    }
                },
                new ClientDto
                {
                    Id = Guid.NewGuid(),
                    Description = "-",
                    Name = "Gheorghe",
                    Location = new HackatonHotels.Core.Models.Hotel.Location
                    {
                        City = "Iasi",
                        Country="Romania",
                        PostalCode = "700703",
                        Street = "Baza 3"
                    }
                },
                new ClientDto
                {
                    Id = Guid.NewGuid(),
                    Description = "-",
                    Name = "Serban",
                    Location = new HackatonHotels.Core.Models.Hotel.Location
                    {
                        City = "Iasi",
                        Country="Romania",
                        PostalCode = "700703",
                        Street = "Baza 3"
                    }
                },
                new ClientDto
                {
                    Id = Guid.NewGuid(),
                    Description = "-",
                    Name = "Gabriel",
                    Location = new HackatonHotels.Core.Models.Hotel.Location
                    {
                        City = "Iasi",
                        Country="Romania",
                        PostalCode = "700703",
                        Street = "Baza 3"
                    }
                }
            };
            var model = new UserListViewModel
            {
                Users = users,
                Roles = roles,
                Clients = clients
            };
            return View(model);
        }
    }
}