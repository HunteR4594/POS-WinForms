using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic; // Required for List<T>

namespace POS_project.Migrations
{
    public class AppDbContext : DbContext
    {
        // These DbSet properties represent your database tables.
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; } // The actual Product entity for 'products' table
        public DbSet<Category> Categories { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SaleItem> SaleItems { get; set; } // NEW: DbSet for SaleItems

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\renren\Documents\newDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True");
        }

        // Configure relationships and precision for decimal types
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure decimal precision for product prices and total amounts
            modelBuilder.Entity<Product>()
                .Property(p => p.prod_price)
                .HasColumnType("decimal(18,2)"); // Adjust precision and scale as needed for your database

            modelBuilder.Entity<Sale>()
                .Property(s => s.TotalAmount)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<SaleItem>()
                .Property(si => si.OrigPrice)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<SaleItem>()
                .Property(si => si.TotalPrice)
                .HasColumnType("decimal(18,2)");

            // Define the relationship: A Sale has many SaleItems
            modelBuilder.Entity<SaleItem>()
                .HasOne(si => si.Sale)        // SaleItem has one Sale
                .WithMany(s => s.SaleItems)   // Sale has many SaleItems
                .HasForeignKey(si => si.SaleId); // Foreign key in SaleItem table
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
        public decimal TotalAmount { get; set; } // This will be the grand total of the sale

        // Navigation property for SaleItems related to this Sale
        public ICollection<SaleItem> SaleItems { get; set; } = new List<SaleItem>();
    }

    // NEW: SaleItem entity to record individual products within a sale
    public class SaleItem
    {
        public int Id { get; set; } // Primary key for SaleItem
        public int SaleId { get; set; } // Foreign key to the Sale table

        public required string ProdId { get; set; } // Product ID (e.g., from Product.prod_id)
        public required string ProdName { get; set; } // Product Name
        public int Quantity { get; set; }
        public decimal OrigPrice { get; set; } // Original unit price of the product
        public decimal TotalPrice { get; set; } // Subtotal for this line item (after discount, before VAT for consistency with receipt)
                                                // Note: Your DataTable has 'Final Subtotal' which includes VAT.
                                                // We will store the final subtotal per item here.

        // Navigation property back to the Sale
        public Sale Sale { get; set; } // Required for EF Core relationship
    }
}
