using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ChopstickDocker.Controllers
{
    public abstract class ChopstickDockerControllerBase: AbpController
    {
        protected ChopstickDockerControllerBase()
        {
            LocalizationSourceName = ChopstickDockerConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
