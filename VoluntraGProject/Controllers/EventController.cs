using Microsoft.AspNetCore.Mvc;

namespace VoluntraGProject.Controllers
{
    public class EventController : Controller
    {
        public IActionResult Event()
        {
            return View();
        }
    }
}
