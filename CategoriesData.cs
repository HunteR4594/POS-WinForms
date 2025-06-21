using POS_project.Migrations;

namespace POS_project
{
    public class CategoriesData
    {
        private readonly AppDbContext _context;

        public CategoriesData()
        {
            _context = new AppDbContext();
        }

        public List<Category> AllCategoriesData()
        {
            return _context.Categories.ToList();
        }
    }
}
