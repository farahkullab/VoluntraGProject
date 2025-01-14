using Microsoft.AspNetCore.Mvc;
using VoluntraGProject.Data;
using VoluntraGProject.Models;

namespace VoluntraGProject.Controllers
{
    public class ApplicationController : Controller
    {
        private readonly AppDbContext _context;

        public ApplicationController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Application()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Apply(Application application)
        {
            {
                application.AppliedDate = DateOnly.FromDateTime(DateTime.Now); // ضبط تاريخ التقديم
                _context.Applications.Add(application); // إضافة البيانات
                _context.SaveChanges(); // حفظ البيانات في قاعدة البيانات
                return RedirectToAction("Confirmation"); // إعادة التوجيه إلى صفحة التأكيد
            }
            return View("Application", application); // إعادة الفورم مع الأخطاء إن وجدت
        }

        [HttpGet]
        public IActionResult Confirmation()
        {
            return View();
        }
    }
}
