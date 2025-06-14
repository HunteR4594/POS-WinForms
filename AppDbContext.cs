using Microsoft.EntityFrameworkCore;

namespace POS_project
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Paula\Documents\LoginData.mdf;Integrated Security=True;TrustServerCertificate=True");
        }
    }

    public class User
    {
        public int Id { get; set; }
        public required string Email { get; set; }
        public required string Username { get; set; }
        public required string Password { get; set; }
        public DateTime Date { get; set; }
    }
}
