using FamilyQuest.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FamilyQuest
{
    public interface IGamesRepository
    {
        List<Game> GetAllGame();
        Game TryGetById(int id);

        void AddGame(Game game);

        void DeleteGame(int id);
    }
}