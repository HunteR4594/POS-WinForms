using Microsoft.EntityFrameworkCore;
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

        public void AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public Product GetProductByBarcode(string barcode)
        {
            return _context.Products.FirstOrDefault(p => p.barcode == barcode || p.prod_id == barcode);
        }

        public void DeleteProduct(int productId)
        {
            var product = _context.Products.Find(productId);
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
        }

        public void UpdateProduct(Product product)
        {
            _context.Entry(product).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}

