using Microsoft.AspNetCore.Mvc;
using VoluntraGProject.Data;
using VoluntraGProject.Models;

namespace VoluntraGProject.Controllers
{
    public class FeedbackController : Controller
    {
        private readonly AppDbContext _context;

        public FeedbackController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Create(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                _context.Feedbacks.Add(feedback);
                _context.SaveChanges();
                TempData["SuccessMessage"] = "Your feedback has been submitted successfully!";
                return RedirectToAction("Index"); // أو أي صفحة تريد إعادة التوجيه إليها
            }

            TempData["ErrorMessage"] = "There was an error submitting your feedback.";
            return RedirectToAction("Index");
        }
    }
}
