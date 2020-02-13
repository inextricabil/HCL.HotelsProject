using System.Collections.Generic;
using HCL.HackatonHotels.Roles.Dto;

namespace HCL.HackatonHotels.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}