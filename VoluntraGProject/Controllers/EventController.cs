using Microsoft.AspNetCore.Mvc;
using VoluntraGProject.Models;
using VoluntraGProject.Data;
using Microsoft.EntityFrameworkCore;

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
            // تحميل جميع الأحداث من قاعدة البيانات
            var events = _context.Events.ToList();
            return View(events);
        }
    }
}
