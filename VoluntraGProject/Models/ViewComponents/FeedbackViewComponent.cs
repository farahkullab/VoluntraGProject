using Microsoft.AspNetCore.Mvc;
using VoluntraGProject.Data;

namespace VoluntraGProject.Models.ViewComponents
{
    public class FeedbackViewComponent : ViewComponent
    {
        private AppDbContext db;
        public FeedbackViewComponent(AppDbContext _db)
        {
            db = _db;

        }
        public IViewComponentResult Invoke()
        {
            return View(db.Feedbacks.ToList());
        }
    }
}
