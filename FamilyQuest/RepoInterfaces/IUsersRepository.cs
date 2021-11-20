using FamilyQuest.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FamilyQuest
{
    public interface IUsersRepository
    {
        List<User> GetAll();

        public void Add(User user);
    }
}