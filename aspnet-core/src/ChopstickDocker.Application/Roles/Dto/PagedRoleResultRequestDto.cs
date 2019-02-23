using Abp.Application.Services.Dto;

namespace ChopstickDocker.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

