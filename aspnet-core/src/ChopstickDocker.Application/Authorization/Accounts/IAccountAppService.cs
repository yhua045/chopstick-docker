using System.Threading.Tasks;
using Abp.Application.Services;
using ChopstickDocker.Authorization.Accounts.Dto;

namespace ChopstickDocker.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
