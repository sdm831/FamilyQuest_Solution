using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FamilyQuest.Models
{
    public class Exercise
    {
        //public Exercise(string userId)
        //{
        //    Id = Guid.NewGuid();
        //    UserId = userId ?? throw new ArgumentNullException(nameof(userId));
        //}

        public Exercise(string userId, string name)
        {
            Id = Guid.NewGuid();
            UserId = userId ?? throw new ArgumentNullException(nameof(userId));
            Name = name;
        }

        public Guid Id { get; }
        public string Name { get; set; }
        public string UserId { get; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public string TrueAnswer { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }
    }
}
