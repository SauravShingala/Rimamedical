using Microsoft.AspNetCore.Mvc;

namespace OrthoModual.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
