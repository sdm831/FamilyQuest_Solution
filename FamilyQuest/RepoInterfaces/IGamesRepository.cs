using FamilyQuest.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FamilyQuest
{
    public interface IGamesRepository
    {
        List<Game> GetAll();

        void Add(Game game);
        //void DelExercise();
    }
}