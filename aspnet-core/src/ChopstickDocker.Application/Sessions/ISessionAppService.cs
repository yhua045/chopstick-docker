using System.Threading.Tasks;
using Abp.Application.Services;
using ChopstickDocker.Sessions.Dto;

namespace ChopstickDocker.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
