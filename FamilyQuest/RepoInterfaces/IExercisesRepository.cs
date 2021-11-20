using FamilyQuest.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FamilyQuest
{
    public interface IExercisesRepository
    {
        List<Exercise> GetAll();

        public void Add(Exercise exercise);
    }
}
