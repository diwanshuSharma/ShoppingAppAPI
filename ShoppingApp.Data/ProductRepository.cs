using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Data
{
    public class ProductRepository
    {
        ProductContextDB db = new ProductContextDB();

        public List<Product> GetProducts()
        {
            var products = db.Products.ToList();
            return products;
        }

        public Product SetProduct(Product product)
        {
            var products = db.Products.Add(product);
            return products;
        }
    }
}
