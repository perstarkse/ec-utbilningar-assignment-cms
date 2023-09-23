using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Web.Common.Controllers;

namespace cms_assignment.Controllers
{
    public class HomeController : UmbracoController
    {
        public IActionResult Index()
        {
            return View("Home");
        }
    }
}
