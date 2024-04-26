using Microsoft.AspNetCore.Mvc;

namespace Globomantics.Survey.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            HttpContext.Session.SetString("Temp", "LoggedIn");
            return View();
        }
    }
}
