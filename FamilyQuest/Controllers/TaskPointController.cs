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
        //private readonly ITaskPointsRepository TaskPointsRepository;
        //
        //public TaskPointController(ITaskPointsRepository TaskPointsRepository)
        //{
        //    this.TaskPointsRepository = TaskPointsRepository;
        //}
        
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
    }
}
