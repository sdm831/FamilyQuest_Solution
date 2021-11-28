using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FamilyQuest.Models
{
    public class GameDbContext
    {        
        public string ConnectionString { get; set; }

        public GameDbContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public List<TaskPoint> GetAllTaskPoints()
        {
            List<TaskPoint> list = new List<TaskPoint>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select Id, Name, AuthorId from TaskPoints", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new TaskPoint()
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Name = reader["Name"].ToString(),
                            AuthorId = Convert.ToInt32(reader["AuthorId"])                            
                        });
                    }
                }
            }
            return list;
        }

        public void AddNewTaskPoint(TaskPoint point)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(
                    $"INSERT INTO `db-quest-test-1`.TaskPoints " +
                    $"(Name, Description, AuthorId, Question, Answer, ImagePath, Share) " +
                    $"VALUES('{point.Name}', '{point.Description}', {point.AuthorId}, " +
                    $"'{point.Question}', '{point.Answer}', '{point.ImagePath}', {point.Share}); ", conn);

                using (var reader = cmd.ExecuteReader()) { }
            }
        }

        public List<Game> GetAllGames()
        {
            List<Game> list = new List<Game>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select Id, Name, AuthorId from Games", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Game()
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Name = reader["Name"].ToString(),
                            AuthorId = Convert.ToInt32(reader["AuthorId"])
                        });
                    }
                }
            }
            return list;
        }
    }
}
