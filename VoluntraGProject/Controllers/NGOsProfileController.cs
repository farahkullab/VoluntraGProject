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
        public IActionResult NGOsProfile()
        {
            var profile = _context.Events.ToList();
            return View(profile);
        }
    }
}