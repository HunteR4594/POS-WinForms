using System.Collections.Generic;
using System.Linq;

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

        public static List<Product> GetLowStockProducts()
        {
            using (var context = new AppDbContext())
            {
                return context.Products.Where(p => p.stock < p.ReorderLevel).ToList();
            }
        }
    }
}

