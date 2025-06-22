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
        public DbSet<Customer> Customers { get; set; } // NEW: DbSet for Customers

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
                .Property(s => s.total_price) // Renamed from TotalAmount
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Sale>()
                .Property(s => s.amount) // New property
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Sale>()
                .Property(s => s.change) // New property
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

            // Configure decimal precision for Customer total_price, amount, and change
            modelBuilder.Entity<Customer>()
                .Property(c => c.total_price)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Customer>()
                .Property(c => c.amount)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Customer>()
                .Property(c => c.change)
                .HasColumnType("decimal(18,2)");
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
        public required decimal prod_price { get; set; }
        public required int stock { get; set; }
        public required string image_path { get; set; }
        public required string status { get; set; }
        public required DateTime date_insert { get; set; }
        public string? barcode { get; set; } // Added this property

    }

    public class Category
    {
        public int id { get; set; }
        public required string CategoryName { get; set; }
    }

    public class Sale // Maps to CustomerOrderEntry
    {
        public int id { get; set; }
        public required string customer_id { get; set; } // Added based on CustomerOrderEntry
        public decimal total_price { get; set; } // Renamed from TotalAmount, maps to total_price in CustomerOrderEntry
        public decimal amount { get; set; } // Added based on CustomerOrderEntry
        public decimal change { get; set; } // Added based on CustomerOrderEntry
        public DateTime order_date { get; set; } // Renamed from SaleDate, maps to order_date in CustomerOrderEntry

        // Navigation property for SaleItems related to this Sale
        public ICollection<SaleItem> SaleItems { get; set; } = new List<SaleItem>();
    }

    public class SaleItem // Maps to orders
    {
        public int id { get; set; } // Renamed from Id, maps to id in orders
        public int SaleId { get; set; } // Foreign key to the Sale table

        public required string ProdId { get; set; } // Maps to prod_id in orders
        public required string ProdName { get; set; } // Maps to prod_name in orders
        public required string customer_id { get; set; } // Added based on orders
        public required string category { get; set; } // Added based on orders
        public int Quantity { get; set; } // Maps to qty in orders
        public decimal OrigPrice { get; set; } // Maps to orig_price in orders
        public decimal TotalPrice { get; set; } // Maps to total_price in orders
        public DateTime order_date { get; set; } // Added based on orders

        // Navigation property back to the Sale
        public Sale Sale { get; set; } // Required for EF Core relationship
    }

    // Customer entity (already added in previous turn)
    public class Customer
    {
        public int id { get; set; }
        public required string customer_id { get; set; }
        public required string prod_id { get; set; }
        public required decimal total_price { get; set; }
        public required decimal amount { get; set; }
        public required decimal change { get; set; }
        public required DateTime order_date { get; set; }
    }
}