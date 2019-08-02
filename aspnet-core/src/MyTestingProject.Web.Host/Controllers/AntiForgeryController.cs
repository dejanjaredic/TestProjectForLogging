using Microsoft.AspNetCore.Antiforgery;
using MyTestingProject.Controllers;

namespace MyTestingProject.Web.Host.Controllers
{
    public class AntiForgeryController : MyTestingProjectControllerBase
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
