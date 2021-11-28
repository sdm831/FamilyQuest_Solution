using FamilyQuest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FamilyQuest
{
    public class TaskPointsInMemoryRepository : ITaskPointsRepository
    {
        private List<TaskPoint> taskPoints = new List<TaskPoint>()
        {
        //    new Exercise("UserId-1", "name-1"),
        //    new Exercise("UserId-1", "name-2"),
        //    new Exercise("UserId-1", "name-3"),
        //    new Exercise("UserId-2", "name-1"),
        //    new Exercise("UserId-2", "name-2")
        };

        public void Add(TaskPoint taskPoint)
        {
            taskPoints.Add(taskPoint);
        }

        //public void Delete(Guid id)
        //{
        //    exercises.Remove();
        //}

        public List<TaskPoint> GetAll()
        {
            return taskPoints;
        }

        public TaskPoint TryGetById(/*Guid*/int id)
        {
            return taskPoints.FirstOrDefault(x => x.Id == id);
        }
    }
}
