using Abp.Application.Services.Dto;

namespace HCL.HackatonHotels.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

