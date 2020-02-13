using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using HCL.HackatonHotels.Configuration.Dto;

namespace HCL.HackatonHotels.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : HackatonHotelsAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
