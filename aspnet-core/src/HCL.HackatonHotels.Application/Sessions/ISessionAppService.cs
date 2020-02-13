using System.Threading.Tasks;
using Abp.Application.Services;
using HCL.HackatonHotels.Sessions.Dto;

namespace HCL.HackatonHotels.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
