using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FamilyQuest.Models
{
    public class Author
    {
        public Guid Id { get; }
        public string Name { get; set; }

        public Author()
        {
            Name = "Djon";
        }

        public Author(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
        }

    }
}
