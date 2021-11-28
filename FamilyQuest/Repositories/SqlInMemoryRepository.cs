using FamilyQuest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FamilyQuest.Repositories
{
    public class SqlInMemoryRepository : ISqlRepository
    {        
        public List<Game> GetAllGames()
        {
            throw new NotImplementedException();
        }

        public List<TaskPoint> GetAllTaskPoints()
        {
            throw new NotImplementedException();
        }

        public Author GetAuthor(int id)
        {
            throw new NotImplementedException();
        }
    }
}
