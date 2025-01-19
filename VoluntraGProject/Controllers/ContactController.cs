using Microsoft.AspNetCore.Mvc;
using VoluntraGProject.Models;
using VoluntraGProject.Data; // تأكد من أنك تستخدم السياق المناسب لقاعدة البيانات

namespace VoluntraGProject.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _context;

        // Constructor to inject the ApplicationDbContext
        public ContactController(AppDbContext context)
        {
            _context = context;
        }

        // POST: Submit contact form
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Submit(Contact contact)
        {
            if (ModelState.IsValid)
            {
                // Adding the contact to the database
                _context.Contacts.Add(contact);
                _context.SaveChanges(); // Saving changes to the database

                // Redirecting with a success message
                TempData["SuccessMessage"] = "Your message has been sent successfully!";
                return RedirectToAction("Index", "Home"); // إعادة توجيه المستخدم لصفحة الهوم
            }

            // If the model state is not valid, stay on the current page
            TempData["ErrorMessage"] = "There was an error in your form submission.";
            return RedirectToAction("Index", "Home");
        }
    }
}
