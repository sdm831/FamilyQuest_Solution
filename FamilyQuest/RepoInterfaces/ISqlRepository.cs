using FamilyQuest.Models;
using System.Collections.Generic;

namespace FamilyQuest
{
    internal interface ISqlRepository
    {
        List<TaskPoint> GetAllTaskPoints();
        List<Game> GetAllGames();
        Author GetAuthor(int id);
    }
}