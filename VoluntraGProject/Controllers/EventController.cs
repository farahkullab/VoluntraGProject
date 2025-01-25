using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore; // تأكد من إضافة هذا
using VoluntraGProject.Data;

namespace VoluntraGProject.Controllers
{
    public class EventController : Controller
    {
        private readonly AppDbContext _context;

        public EventController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Event()
        {
            // تحميل الأحداث مع الكيان المرتبط (NGO)
            var events = _context.Events
                                 .Include(e => e.NGO) // تضمين الكيان المرتبط
                                 .ToList();
            return View(events);
        }
    }
}
