using Microsoft.AspNetCore.Mvc;
using VoluntraGProject.Data;

namespace VoluntraGProject.Controllers
{
    public class NGOsProfileController : Controller
    {

        private readonly AppDbContext _context;

        public NGOsProfileController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult NGOsProfile(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var profile = _context.NGOs.Find(id);

            if (profile == null)
            {
                return NotFound();
            }

            return View(profile);
        }
    }
}