using POS_project;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace POS_project
{
    internal class UsersData
    {
        private readonly AppDbContext _context;

        public UsersData()
        {
            _context = new AppDbContext();
        }

        public List<User> AllUsersData()
        {
            return _context.Users.Where(u => !u.IsDeleted).ToList();
        }
    }

    public static class PasswordHelper
    {
        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public static bool VerifyPassword(string enteredPassword, string storedHash)
        {
            string enteredHash = HashPassword(enteredPassword);
            return string.Equals(enteredHash, storedHash);
        }
    }
}
