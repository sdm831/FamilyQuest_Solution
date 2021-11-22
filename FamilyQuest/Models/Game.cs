using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FamilyQuest.Models
{
    public class Game
    {
        public Guid Id { get;  }
        public string GameName { get; set; }
        public string ClientName { get; set; }
        public string UserId { get; set; }
        public List<Exercise> Exercises { get; set; }
    }
}
