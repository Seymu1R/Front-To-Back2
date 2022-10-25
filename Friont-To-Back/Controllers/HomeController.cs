using Microsoft.AspNetCore.Mvc;

namespace Friont_To_Back.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Shop()
        {
            return View();
        }
    }
}
