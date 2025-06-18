using System.Data.SqlClient;

namespace POS_project
{
    internal class CategoriesData
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        // This method should return a list of CategoriesData objects
        // It should handle its own connection and data retrieval logic
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\renren\Documents\newDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True";
        public List<CategoriesData> AllCategoriesData()
        {
            List<CategoriesData> categories = new List<CategoriesData>();
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                try
                {
                    connect.Open();
                    string query = "SELECT * FROM categories"; // Adjust the query as needed
                    using (SqlCommand command = new SqlCommand(query, connect))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CategoriesData category = new CategoriesData
                            {
                                Id = reader.GetInt32(0), // Assuming Id is the first column
                                Category = reader.GetString(1), // Assuming Category is the second column
                                CreatedAt = reader.GetDateTime(2), // Assuming CreatedAt is the third column
                                UpdatedAt = reader.GetDateTime(3) // Assuming UpdatedAt is the fourth column
                            };
                            categories.Add(category);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions as needed, e.g., log them or rethrow
                    Console.WriteLine("Error retrieving categories: " + ex.Message);
                }
            }
            return new List<CategoriesData>();
        }
    }
}
