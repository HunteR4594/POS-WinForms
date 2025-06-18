using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data; // Ensure you have this for DataTable and related classes

namespace POS_project
{
    internal class ProductData
    {
        public int ID { get; set; } //0
        public string ProdID { get; set; } //1
        public string ProdName { get; set; } //2
        public string Category { get; set; } //3
        public string Price { get; set; } //4
        public string Stock { get; set; } //5   
        public string ImagePath { get; set; }  //6
        public string Status { get; set; } //7
        public string Date { get; set; } //8


        // Fixing the return type to match the method's intended purpose
        public List<ProductData> AllProductData()
        {
            List<ProductData> listdata = new List<ProductData>();

            using (SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\renren\Documents\newDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True"))
            {
                connect.Open();
                string query = "SELECT * FROM products"; // Corrected table name typo
                using (SqlCommand command = new SqlCommand(query, connect))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        ProductData pData = new ProductData();
                        pData.ID = (int)reader["id"];
                        pData.ProdID = reader["prod_id"].ToString();
                        pData.ProdName = reader["prod_name"].ToString();
                        pData.Category = reader["category"].ToString();
                        pData.Price = reader["prod_price"].ToString();
                        pData.Stock = reader["stock"].ToString();
                        pData.ImagePath = reader["image_path"].ToString();
                        pData.Status = reader["status"].ToString();
                        pData.Date = reader["date_insert"].ToString();


                        listdata.Add(pData);
                    }
                }
            }
            return listdata;
        }
        
        public List<ProductData> allAvailableProducts()
        { 
            List<ProductData> listdata = new List<ProductData>();

            using (SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\renren\Documents\newDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True"))
            {
                connect.Open();
                string query = "SELECT * FROM products WHERE status = @status"; // Corrected table name typo
                using (SqlCommand command = new SqlCommand(query, connect))
                {   
                    command.Parameters.AddWithValue("@status", "Available"); // Assuming 'Available' is the status you want to filter by
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        ProductData pData = new ProductData();
                        pData.ID = (int)reader["id"];
                        pData.ProdID = reader["prod_id"].ToString();
                        pData.ProdName = reader["prod_name"].ToString();
                        pData.Category = reader["category"].ToString();
                        pData.Price = reader["prod_price"].ToString();
                        pData.Stock = reader["stock"].ToString();
                        pData.ImagePath = reader["image_path"].ToString();
                        pData.Status = reader["status"].ToString();
                        pData.Date = reader["date_insert"].ToString();


                        listdata.Add(pData);
                    }
                }
            }
            return listdata;
        }
    }

}

