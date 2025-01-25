using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

            // جلب المنظمة مع الإيفنتات المرتبطة بها
            var profile = _context.NGOs
                .Include(n => n.Events.OrderByDescending(e => e.EventDate)) // تأكد أن اسم العلاقة هو "Events" (تعديل الاسم إذا كان مختلفًا)
                .FirstOrDefault(n => n.NGOId == id);

            if (profile == null)
            {
                return NotFound();
            }

            return View(profile);
        }
    }
}
