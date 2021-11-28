using FamilyQuest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FamilyQuest.Repositories
{
    public class GamesInMemoryRepository : IGamesRepository
    {
        private List<Game> games = new List<Game>();

        public List<Game> GetAllGame()
        {
            return games;
        }

        public Game TryGetById(int id)
        {
            return games.FirstOrDefault(x => x.Id == id);
        }
        
        public void AddGame(Game game)
        {
            throw new NotImplementedException();
        }                

        public void DeleteGame(int id)
        {
            throw new NotImplementedException();
        }
    }
}
