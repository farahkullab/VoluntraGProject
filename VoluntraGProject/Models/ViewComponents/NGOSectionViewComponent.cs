using Microsoft.AspNetCore.Mvc;
using VoluntraGProject.Data;

namespace VoluntraGProject.Models.ViewComponents
{
    public class NGOSectionViewComponent : ViewComponent
    {
        private AppDbContext db;
        public NGOSectionViewComponent(AppDbContext _db)
        {
            db = _db;

        }
        public IViewComponentResult Invoke()
        {
            return View(db.NGOs.ToList());
        }
    }
}
