using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;

namespace POS_project
{
    internal class UsersData
    {
        private SqlConnection connect;
        public string ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Status { get; set; }
        public string date { get; set; }

        public List<UsersData> AllUsersData()
        {
            List<UsersData> usersList = new List<UsersData>();
            using (SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-5MGMHRD;Initial Catalog=testdb;Integrated Security=True;Encrypt=True;Trust Server Certificate=True"))
            {
                connect.Open();
                string query = "SELECT * FROM users";
                using (SqlCommand command = new SqlCommand(query, connect))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        UsersData user = new UsersData
                        {
                            ID = reader["id"].ToString(),
                            Username = reader["username"].ToString(),
                            Password = reader["password"].ToString(),
                            Role = reader["role"].ToString(),
                            Status = reader["status"].ToString(),
                            date = reader["date"].ToString()
                        };

                        usersList.Add(user);
                    }
                }
            }
            return usersList;
        }
    }
}
