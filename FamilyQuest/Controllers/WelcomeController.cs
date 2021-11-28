using FamilyQuest.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FamilyQuest.Controllers
{
    public class WelcomeController : Controller
    {
        [HttpPost]
        public IActionResult Login(Author user)
        {
            return View(user);
        }

        //public IActionResult Login(User user)
        //{
        //    return View(user);
        //}
    }
}
