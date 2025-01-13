using Microsoft.AspNetCore.Mvc;

namespace VoluntraGProject.Controllers
{
    public class ApplicationController : Controller
    {
        public IActionResult Application()
        {
            return View();
        }
    }
}
