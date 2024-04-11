using Microsoft.AspNetCore.Mvc;

namespace digitalerashopby.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
