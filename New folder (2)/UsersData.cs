using Microsoft.Data.SqlClient;

namespace POS_project
{
    internal class UsersData
    {
        private SqlConnection connect;
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Status { get; set; }
        public string Date { get; set; }

        public List<UsersData> AllUsersData()
        {
            List<UsersData> usersList = new List<UsersData>();
            using (SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\renren\Documents\newDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True"))
            {
                connect.Open();
                string query = "SELECT * FROM users WHERE IsDeleted = 0";
                using (SqlCommand command = new SqlCommand(query, connect))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        UsersData user = new UsersData
                        {
                            ID = (int)reader["id"],
                            Username = reader["username"].ToString(),
                            Password = reader["password"].ToString(),
                            Role = reader["role"].ToString(),
                            Status = reader["status"].ToString(),
                            Date = reader["date"].ToString()
                        };

                        usersList.Add(user);
                    }
                }
            }
            return usersList;
        }
    }
}
