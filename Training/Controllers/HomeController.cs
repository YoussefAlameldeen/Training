using Microsoft.AspNetCore.Mvc;

namespace Training.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
