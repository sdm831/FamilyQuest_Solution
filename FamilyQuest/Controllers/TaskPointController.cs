using FamilyQuest.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FamilyQuest.Controllers
{
    public class TaskPointController : Controller
    {        
        public IActionResult Index()
        {
            GameDbContext context = HttpContext.RequestServices.GetService(typeof(FamilyQuest.Models.GameDbContext)) as GameDbContext;

            return View(context.GetAllTaskPoints());
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(TaskPoint point)
        {
            GameDbContext context = HttpContext.RequestServices.GetService(typeof(FamilyQuest.Models.GameDbContext)) as GameDbContext;
            context.AddNewTaskPoint(point);
            return RedirectToAction("Index", "TaskPoint");
        }

        public IActionResult Delete(int id)
        {
            GameDbContext context = HttpContext.RequestServices.GetService(typeof(FamilyQuest.Models.GameDbContext)) as GameDbContext;
            context.DeleteTaskPoint(id); 
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            GameDbContext context = HttpContext.RequestServices.GetService(typeof(FamilyQuest.Models.GameDbContext)) as GameDbContext;
             
            return View(context.GetTaskPointById(id));
        }

        [HttpPost]
        public IActionResult Edit(TaskPoint point)
        {
            GameDbContext context = HttpContext.RequestServices.GetService(typeof(FamilyQuest.Models.GameDbContext)) as GameDbContext;
            context.EditTaskPoint(point);
            return RedirectToAction("Index", "TaskPoint");
        }
    }
}
