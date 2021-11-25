﻿using FamilyQuest.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FamilyQuest
{
    public interface IExercisesRepository
    {
        List<Exercise> GetAll();
        Exercise TryGetById(/*Guid*/int id);
        void Add(Exercise exercise);
    }
}
