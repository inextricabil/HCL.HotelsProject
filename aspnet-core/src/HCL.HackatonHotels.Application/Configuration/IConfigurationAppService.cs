using System.Threading.Tasks;
using HCL.HackatonHotels.Configuration.Dto;

namespace HCL.HackatonHotels.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
