using System.Collections.Generic;
using HCL.HackatonHotels.Roles.Dto;

namespace HCL.HackatonHotels.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleListDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
