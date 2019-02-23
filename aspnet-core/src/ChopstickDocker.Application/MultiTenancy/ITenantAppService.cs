using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ChopstickDocker.MultiTenancy.Dto;

namespace ChopstickDocker.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

