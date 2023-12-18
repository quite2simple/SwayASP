using Microsoft.AspNetCore.Mvc;
using SwayASP.Models;

namespace SwayASP.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationContext db;

        public HomeController(ApplicationContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            ViewData["Path"] = "";
            return View();
        }

        [HttpPost]
        public IActionResult Index(string a, string b)
        {
            Station s1 = db.Stations.First(x => x.Name == a);
            Station s2 = db.Stations.First(x => x.Name == b);
            ViewData["Path"] = PathfinderPlaceholder.Path(s1, s2, db);
            return View();
        }

        public IActionResult OldMaps()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
    }
}
