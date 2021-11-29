using FamilyQuest.Models;
using Microsoft.AspNetCore.Mvc;
using Stepik_ASP_Core_MVC_course.Models;

namespace Stepik_ASP_Core_MVC_course.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Login login)
        {
            GameDbContext context = HttpContext.RequestServices.GetService(typeof(FamilyQuest.Models.GameDbContext)) as GameDbContext;

            if (context.GetUser(login))
            {
                return RedirectToAction("Index", "Game");
            }
            return RedirectToAction("Fail", "Account");
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Register register)
        {
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Fail()
        {
            return View();
        }
    }
}
