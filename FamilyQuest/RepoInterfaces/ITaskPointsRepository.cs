﻿using FamilyQuest.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FamilyQuest
{
    public interface ITaskPointsRepository
    {
        List<TaskPoint> GetAll();
        TaskPoint TryGetById(int id);
        void Add(TaskPoint exercise);
    }
}
