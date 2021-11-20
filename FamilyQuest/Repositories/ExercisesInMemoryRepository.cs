using FamilyQuest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FamilyQuest
{
    public class ExercisesInMemoryRepository : IExercisesRepository
    {
        private List<Exercise> exercises = new List<Exercise>()
        {
            new Exercise("UserId-1"),
            new Exercise("UserId-2")
        };

        public void Add(Exercise exercise)
        {
            exercises.Add(exercise);
        }

        public List<Exercise> GetAll()
        {
            return exercises;
        }        
    }
}
