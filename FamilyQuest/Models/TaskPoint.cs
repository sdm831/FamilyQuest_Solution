using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FamilyQuest.Models
{
    public class TaskPoint
    {        
        public int Id { get; set; }
        public string Name { get; set; }
        public int AuthorId { get; set; }
        public string Description { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public string ImagePath { get; set; }
        public int Share { get; set; }

        public string UserAnswer { get; set; }
    }
}
