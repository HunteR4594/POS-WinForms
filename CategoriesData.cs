using Microsoft.Data.SqlClient;

namespace POS_project
{
    internal class CategoriesData
    {
        public int ID { get; set; }
        public string Category { get; set; }
        public string Date { get; set; }

        // Fixing the return type to match the method's intended purpose
        public List<CategoriesData> AllCategoriesData()
        {
            List<CategoriesData> listdata = new List<CategoriesData>();

            using (SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-5MGMHRD;Initial Catalog=testdb;Integrated Security=True;Encrypt=True;Trust Server Certificate=True"))
            {
                connect.Open();
                string query = "SELECT * FROM categories"; // Corrected table name typo
                using (SqlCommand command = new SqlCommand(query, connect))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        CategoriesData cData = new CategoriesData();
                        cData.ID = (int)reader["id"];
                        cData.Category = reader["category"].ToString();
                        cData.Date = reader["date"].ToString();

                        listdata.Add(cData);
                    }
                }
            }
            return listdata;
        }
    }
}
