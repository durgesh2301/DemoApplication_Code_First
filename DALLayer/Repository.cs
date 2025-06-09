using DALLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALLayer
{
    public class Repository
    {
        private DemoDBContext _context;
        public Repository(DemoDBContext context)
        {
            _context = context;
        }

        public List<Category> GetAllCategories()
        {
            List<Category> categories = new List<Category>();
            try
            {
                categories = _context.Categories.OrderBy(c => c.CategoryId).ToList();
            }
            catch (Exception ex)
            {
                categories = null;
            }
            return categories;
        }

        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();
            try
            {
                products = _context.Products.OrderBy(p => p.ProductId).ToList();
            }
            catch (Exception ex)
            {
                products = null;
            }
            return products;
        }

    }
}
