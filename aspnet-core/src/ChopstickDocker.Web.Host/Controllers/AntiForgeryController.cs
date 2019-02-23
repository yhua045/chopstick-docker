using Microsoft.AspNetCore.Antiforgery;
using ChopstickDocker.Controllers;

namespace ChopstickDocker.Web.Host.Controllers
{
    public class AntiForgeryController : ChopstickDockerControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
