using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FamilyQuest.Models
{
    public class Game
    {
        public Game()
        {            
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int AuthorId { get; set; }
        public int GamerId { get; set; }
        public string ImagePath { get; set; }
        public bool Share { get; set; }                
    }
}
