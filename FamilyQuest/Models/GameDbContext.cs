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

        public List<Exercise> GetAllExercise()
        {
            List<Exercise> list = new List<Exercise>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from TaskPoints", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Exercise()
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Name = reader["Name"].ToString(),
                            UserId = "dfg"
                            //ArtistName = reader["ArtistName"].ToString(),
                            //Price = Convert.ToInt32(reader["Price"]),
                            //Genre = reader["genre"].ToString()
                        });
                    }
                }
            }
            return list;
        }
    }
}
