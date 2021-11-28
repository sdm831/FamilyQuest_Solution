using FamilyQuest.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FamilyQuest.Controllers
{
    public class GameController : Controller
    {
        public IActionResult Index()
        {
            GameDbContext context = HttpContext.RequestServices.GetService(typeof(FamilyQuest.Models.GameDbContext)) as GameDbContext;

            return View(context.GetAllGames());
        }

        public IActionResult Add()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult Add()
        //{
        //    GameDbContext context = HttpContext.RequestServices.GetService(typeof(FamilyQuest.Models.GameDbContext)) as GameDbContext;
        //    context.AddNewTaskPoint(point);
        //    return RedirectToAction("Index", "Game");
        //}
    }
}
