using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SwayASP.Models;

namespace SwayASP.Controllers
{
    public class EditorController : Controller
    {
        private ApplicationContext db;

        public EditorController(ApplicationContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Stations()
        {
            return View(await db.Stations.ToListAsync());
        }
    }
}
