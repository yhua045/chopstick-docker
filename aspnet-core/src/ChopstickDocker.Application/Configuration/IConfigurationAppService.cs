using System.Threading.Tasks;
using ChopstickDocker.Configuration.Dto;

namespace ChopstickDocker.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
