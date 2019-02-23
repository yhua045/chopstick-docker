using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ChopstickDocker.Configuration.Dto;

namespace ChopstickDocker.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ChopstickDockerAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
