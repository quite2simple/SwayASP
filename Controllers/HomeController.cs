using Microsoft.AspNetCore.Mvc;

namespace SwayASP.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
