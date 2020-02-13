using System.Collections.Generic;
using System.Threading.Tasks;
using HCL.HackatonHotels.Controllers;
using HCL.HackatonHotels.Roles.Dto;
using HCL.HackatonHotels.Users;
using HCL.HackatonHotels.Users.Dto;
using HCL.HackatonHotels.Web.Models.Users;
using Microsoft.AspNetCore.Mvc;
using RestSharp;

namespace HCL.HackatonHotels.Web.Mvc.Controllers
{
    public class RoomsController : HackatonHotelsControllerBase
    {
        private readonly IUserAppService _userAppService;

        public RoomsController(IUserAppService userAppService)
        {
            this._userAppService = userAppService;
        }

        public async Task<IActionResult> Index()
        {
            IReadOnlyList<UserDto> users = (await this._userAppService.GetAll(new PagedUserResultRequestDto { MaxResultCount = int.MaxValue })).Items; // Paging not implemented yet
            IReadOnlyList<RoleDto> roles = (await this._userAppService.GetRoles()).Items;

            RestClient restClient = new RestClient("http://localhost:21021/api");
            RestRequest request = new RestRequest(Method.GET)
            {
                Resource = "/rooms"
            };

            IRestResponse result = await restClient.ExecuteAsync(request);

            List<RoomDto> rooms = new List<RoomDto>();

            if (result.IsSuccessful)
            {
            }

            UserListViewModel model = new UserListViewModel
            {
                Users = users,
                Roles = roles,
                Rooms = rooms
            };
            return this.View(model);
        }
    }
}