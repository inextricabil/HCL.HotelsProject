using System.Collections.Generic;
using HCL.HackatonHotels.Roles.Dto;
using HCL.HackatonHotels.Users.Dto;

namespace HCL.HackatonHotels.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }

        public IReadOnlyList<RoomDto> Rooms { get; set; }

    }
}
