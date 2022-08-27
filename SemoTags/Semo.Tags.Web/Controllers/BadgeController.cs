using Microsoft.AspNetCore.Mvc;

namespace Semo.Tag.Web.Controllers
{
    public class BadgeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
