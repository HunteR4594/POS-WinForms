using POS_project.Migrations;

namespace POS_project
{
    internal class ProductData
    {
        private readonly AppDbContext _context;

        public ProductData()
        {
            _context = new AppDbContext();
        }

        public List<Product> AllProductData()
        {
            return _context.Products.ToList();
        }

        public List<Product> allAvailableProducts()
        {
            return _context.Products.Where(p => p.status == "Available").ToList();
        }
    }
}

