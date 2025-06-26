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
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-5MGMHRD\SQLEXPRESS01;Initial Catalog=Inventory;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
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

            // Configure Product-Category relationship
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId);

            // Configure SaleItem-Product relationship
            modelBuilder.Entity<SaleItem>()
                .HasOne(si => si.Product)
                .WithMany(p => p.SaleItems)
                .HasForeignKey(si => si.ProductId);

            // Configure Sale-User (Cashier) relationship
            modelBuilder.Entity<Sale>()
                .HasOne(s => s.Cashier)
                .WithMany(u => u.Sales)
                .HasForeignKey(s => s.CashierId);
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

        public ICollection<Sale> Sales { get; set; } = new List<Sale>(); // New: Navigation property for Sales made by this user
    }

    public class Product
    {
        public int id { get; set; }
        public required string prod_id { get; set; }
        public required string prod_name { get; set; }
        public int CategoryId { get; set; } // New: Foreign key to Category
        public required string category { get; set; }

        public Category Category { get; set; } = null!; // New: Navigation property to Category

        public required decimal prod_price { get; set; }
        public required int stock { get; set; }
        public required string image_path { get; set; }
        public required string status { get; set; }
        public required DateTime date_insert { get; set; }
        public string? barcode { get; set; }

        public ICollection<SaleItem> SaleItems { get; set; } = new List<SaleItem>(); // New: Navigation property for SaleItems containing this product
    }

    public class Category
    {
        public int id { get; set; }
        public required string CategoryName { get; set; }

        public ICollection<Product> Products { get; set; } = new List<Product>(); // New: Navigation property for Products in this category
    }

    public class Sale // Maps to CustomerOrderEntry
    {
        public int id { get; set; }
        public required string customer_id { get; set; }

        public int CashierId { get; set; } // New: Foreign key to User (Cashier)
        public User Cashier { get; set; } = null!; // New: Navigation property to User (Cashier)

        public decimal total_price { get; set; }
        public decimal amount { get; set; }
        public decimal change { get; set; }
        public DateTime order_date { get; set; }

        // Navigation property for SaleItems related to this Sale (already exists)
        public ICollection<SaleItem> SaleItems { get; set; } = new List<SaleItem>();
    }

    public class SaleItem // Maps to orders
    {
        public int id { get; set; } // Renamed from Id, maps to id in orders
        public int SaleId { get; set; } // Foreign key to the Sale table

        public required string ProdId { get; set; }

        public int ProductId { get; set; } // New: Foreign key to Product
        public Product Product { get; set; } = null!; // New: Navigation property to Product

        public required string ProdName { get; set; } // Maps to prod_name in orders
        public required string customer_id { get; set; } // Added based on orders
        public required string category { get; set; } // Added based on orders
        public int Quantity { get; set; } // Maps to qty in orders
        public decimal OrigPrice { get; set; } // Maps to orig_price in orders
        public decimal TotalPrice { get; set; } // Maps to total_price in orders
        public DateTime order_date { get; set; } // Added based on orders

        // Navigation property back to the Sale (already exists)
        public Sale Sale { get; set; } = null!; // Ensure it's not nullable for required relationship

        //public int UserId { get; set; } // Foreign key to User (Cashier)
        public required string Username { get; set; }
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