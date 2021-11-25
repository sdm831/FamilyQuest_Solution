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
        //    new Exercise("UserId-1", "name-1"),
        //    new Exercise("UserId-1", "name-2"),
        //    new Exercise("UserId-1", "name-3"),
        //    new Exercise("UserId-2", "name-1"),
        //    new Exercise("UserId-2", "name-2")
        };

        public void Add(Exercise exercise)
        {
            exercises.Add(exercise);
        }

        //public void Delete(Guid id)
        //{
        //    exercises.Remove();
        //}

        public List<Exercise> GetAll()
        {
            return exercises;
        }

        public Exercise TryGetById(/*Guid*/int id)
        {
            return exercises.FirstOrDefault(x => x.Id == id);
        }
    }
}
