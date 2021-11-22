using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FamilyQuest.Models
{
    public class User
    {
        public Guid Id { get; }
        public string UserName { get; set; }

        public User()
        {
            UserName = "Djon";
        }

        public User(string username)
        {
            Id = Guid.NewGuid();
            UserName = username;
        }

    }
}
