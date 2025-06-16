using Microsoft.AspNetCore.Mvc;

namespace Categories.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
