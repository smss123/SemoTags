using Microsoft.AspNetCore.Mvc;

namespace Semo.Tag.Web.Controllers
{
    public class BreadcrumbController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
