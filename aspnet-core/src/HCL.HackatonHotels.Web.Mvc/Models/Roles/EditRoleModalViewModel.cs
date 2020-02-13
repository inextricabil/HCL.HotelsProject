using Abp.AutoMapper;
using HCL.HackatonHotels.Roles.Dto;
using HCL.HackatonHotels.Web.Models.Common;

namespace HCL.HackatonHotels.Web.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class EditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool HasPermission(FlatPermissionDto permission)
        {
            return GrantedPermissionNames.Contains(permission.Name);
        }
    }
}
