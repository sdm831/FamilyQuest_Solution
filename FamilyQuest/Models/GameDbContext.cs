using MySql.Data.MySqlClient;
using Stepik_ASP_Core_MVC_course.Models;
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

        internal TaskPoint GetTaskPointById(int id)
        {
            var tp = new TaskPoint();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand($"select * from TaskPoints where id = {id}", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        tp.Id = id;
                        tp.AuthorId = Convert.ToInt32(reader["AuthorId"]);
                        tp.Name = reader["Name"].ToString();
                        tp.ImagePath = reader["ImagePath"].ToString();
                        tp.Question = reader["Question"].ToString();
                        tp.Answer = reader["Answer"].ToString();
                        tp.Description = reader["Description"].ToString();
                    }
                }
            }
            return tp;
        }

        internal void EditTaskPoint(TaskPoint point)
        {
            string sql = 
                $"UPDATE `db-quest-test-1`.TaskPoints "+
                $"SET Name = '{point.Name}', Description = '{point.Description}', AuthorId = {point.AuthorId}, Question = '{point.Question}', " +
                $"Answer = '{point.Answer}', ImagePath = '{point.ImagePath}' " +
                $"WHERE Id = {point.Id}; ";

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                using (var reader = cmd.ExecuteReader())
                {
                }
            }
        }

        internal void DeleteTaskPoint(int id)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(
                    $"DELETE FROM `db-quest-test-1`.TaskPoints " +
                    $"WHERE id = {id};", conn);

                using (var reader = cmd.ExecuteReader())
                {
                }
            }            
        }

        public bool AddAuthor(Register register)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(
                    $"INSERT INTO `db-quest-test-1`.Authors " +
                    $"(Name, Password) " +
                    $"VALUES('{register.Name}', '{register.Password}'); ", conn);

                using (var reader = cmd.ExecuteReader()) 
                {
                }
            }
            return true;
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
                    $"'{point.Question}', '{point.Answer}', '{point.ImagePath}', '{point.Share}'); ", conn);

                using (var reader = cmd.ExecuteReader()) { }
            }
        }

        internal bool GetUser(Login login)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand($"select count(*) cnt from `db-quest-test-1`.Authors " +
                    $"where name = '{login.Name}' and password = '{login.Password}'", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (Convert.ToInt32(reader["cnt"]) == 1)
                        {
                            return true;
                        }
                    }
                    return false;
                }
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
