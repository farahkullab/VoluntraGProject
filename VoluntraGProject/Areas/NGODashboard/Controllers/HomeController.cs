using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace VoluntraGProject.Areas.NGODashboard.Controllers
{
    [Area("NGODashboard")]
    [Authorize(Roles = "NGO")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
