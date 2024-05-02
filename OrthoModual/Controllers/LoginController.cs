using Microsoft.AspNetCore.Mvc;

namespace OrthoModual.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string name)
        {
            return RedirectToAction("Index", "Dashboard");
        }

        public IActionResult Register()
        {
            return View();
        }
    }
}
