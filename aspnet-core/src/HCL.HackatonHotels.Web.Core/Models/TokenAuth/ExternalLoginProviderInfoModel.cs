using Abp.AutoMapper;
using HCL.HackatonHotels.Authentication.External;

namespace HCL.HackatonHotels.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
