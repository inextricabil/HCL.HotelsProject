using Abp.AutoMapper;
using HCL.HackatonHotels.Sessions.Dto;

namespace HCL.HackatonHotels.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}
