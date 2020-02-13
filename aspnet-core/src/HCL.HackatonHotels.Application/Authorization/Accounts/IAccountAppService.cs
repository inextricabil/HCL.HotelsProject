using System.Threading.Tasks;
using Abp.Application.Services;
using HCL.HackatonHotels.Authorization.Accounts.Dto;

namespace HCL.HackatonHotels.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
