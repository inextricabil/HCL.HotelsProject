using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HCL.HackatonHotels.MultiTenancy.Dto;

namespace HCL.HackatonHotels.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

