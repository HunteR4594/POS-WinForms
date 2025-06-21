using Microsoft.EntityFrameworkCore;
using System; // For DateTime

namespace POS_project
{
    public class AppDbContext : DbContext
    {
        internal object customers;

        // These DbSet properties represent your database tables.
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; } // The actual Product entity for 'products' table
        public DbSet<Category> Categories { get; set; }
        public DbSet<Sale> Sales { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-5MGMHRD;Initial Catalog=testdb;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        }
    }

    // --- EF Core Entities (POCOs mapped to DB tables) ---

    public class User
    {
        public int id { get; set; }
        public required string Email { get; set; }
        public required string Username { get; set; }
        public required string Password { get; set; }
        public required string Role { get; set; }
        public required string Status { get; set; }
        public DateTime Date { get; set; }
        public bool IsDeleted { get; set; }
    }

    // This is the correct Product entity for your 'products' table.
    // Ensure the types here match your actual database column types.
    // It is crucial that prod_price is decimal/double and stock is int.
    public class Product
    {
        public int id { get; set; }
        public required string prod_id { get; set; }
        public required string prod_name { get; set; }
        public required string category { get; set; }
        public required decimal prod_price { get; set; } // Changed to decimal as per your AppDbContext.cs
        public required int stock { get; set; }         // Changed to int as per your AppDbContext.cs
        public required string image_path { get; set; }
        public required string status { get; set; }
        public required DateTime date_insert { get; set; }
        public int ReorderLevel { get; set; } // Low stock threshold
    }

    public class Category
    {
        public int id { get; set; }
        public required string CategoryName { get; set; }
    }

    public class Sale
    {
        public int id { get; set; }
        public DateTime SaleDate { get; set; }
        public decimal TotalAmount { get; set; }
    }

    public class CustomerOrderEntry
    {
        public int id { get; set; } // Primary Key for this specific transaction entry
        public required string customer_id { get; set; } // An identifier for the customer (e.g., a customer code or name)
        public required string prod_id { get; set; }     // The ID of the product involved in this transaction entry
        public required decimal total_price { get; set; } // The total price for this specific entry (e.g., quantity * unit price)
        public required decimal amount { get; set; }      // The amount paid by the customer for this entry (overall transaction amount)
        public required decimal change { get; set; }      // The change given back to the customer (overall transaction change)
        public DateTime order_date { get; set; }          // The date and time of this order/transaction entry
    }
}


