using Abp.AutoMapper;
using ChopstickDocker.Authentication.External;

namespace ChopstickDocker.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
