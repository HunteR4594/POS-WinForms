using POS_project;
using System.Collections.Generic;
using System.Linq;

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
}
