using Microsoft.AspNetCore.Mvc;

namespace Kurumsal.WebUI.Controllers
{
    public class WebDashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
