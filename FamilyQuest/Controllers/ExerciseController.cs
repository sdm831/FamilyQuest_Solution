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
            var exercises = exercisesRepository.GetAll();
            return View(exercises);
        }
    }
}
