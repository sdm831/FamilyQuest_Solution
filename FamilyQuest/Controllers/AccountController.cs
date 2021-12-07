using FamilyQuest.Models;
using Microsoft.AspNetCore.Mvc;
using Stepik_ASP_Core_MVC_course.Models;
using System.Configuration;

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

            //GameDbContext context = Configuration.GetConnectionString("DbConnection");
            //GameDbContext context = Configuration.GetConnectionString("DefaultConnection");
            
            if (context.GetUser(login))
            {
                return RedirectToAction("Index", "Game"/*, login.Name*/);
            }
            return RedirectToAction("LoginFail", "Account");
        }

        public IActionResult LoginFail()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Register register)
        {
            GameDbContext context = HttpContext.RequestServices.GetService(typeof(FamilyQuest.Models.GameDbContext)) as GameDbContext;

            if (context.AddAuthor(register))
            {
                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("FailRegister", "Account");                                    
        }
    }
}
