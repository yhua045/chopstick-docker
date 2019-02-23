using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ChopstickDocker.Roles.Dto;
using ChopstickDocker.Users.Dto;

namespace ChopstickDocker.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
