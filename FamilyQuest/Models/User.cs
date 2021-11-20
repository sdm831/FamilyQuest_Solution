using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FamilyQuest.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public User(string userName)
        {
            Id = Guid.NewGuid();
            Name = userName;
        }
    }
}
