using FamilyQuest.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FamilyQuest.Controllers
{
    public class ExerciseController : Controller
    {
        private readonly IExercisesRepository exercisesRepository;
        
        public ExerciseController(IExercisesRepository exercisesRepository)
        {
            this.exercisesRepository = exercisesRepository;
        }
        
        public IActionResult Index()
        {
            GameDbContext context = HttpContext.RequestServices.GetService(typeof(FamilyQuest.Models.GameDbContext)) as GameDbContext;

            return View(context.GetAllExercise());
            
            //var exercises = exercisesRepository.GetAll();
            //return View(exercises);
        }
    }
}
