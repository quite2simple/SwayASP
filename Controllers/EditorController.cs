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
            return View(await db.Stations.Include(u => u.Line).ToListAsync());
        }
        public async Task<IActionResult> Lines()
        {
            return View(await db.Lines.ToListAsync());
        }

        public async Task<IActionResult> EditStation(int? id)
        {
            if (id != null)
            {
                Station? station = await db.Stations.FirstOrDefaultAsync(p => p.Id == id);
                if (station != null)
                    return View(station);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> EditStation(Station station)
        {
            db.Stations.Update(station);
            await db.SaveChangesAsync();
            return RedirectToAction("Stations");
        }
    }
}
