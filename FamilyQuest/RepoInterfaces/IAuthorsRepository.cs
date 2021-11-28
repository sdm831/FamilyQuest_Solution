using FamilyQuest.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FamilyQuest
{
    public interface IAuthorsRepository
    {
        List<Author> GetAll();

        public void Add(Author author);
    }
}