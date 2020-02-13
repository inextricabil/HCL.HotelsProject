using System.Collections.Generic;

namespace HCL.HackatonHotels.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
