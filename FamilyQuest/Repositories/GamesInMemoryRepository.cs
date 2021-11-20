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

        public void Add(Game game)
        {
            throw new NotImplementedException();
        }

        public List<Game> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
