using Microsoft.AspNetCore.Cors;
using ShoppingApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace ShoppingApp.API.Controllers
{
    public class ProductController : ApiController
    {

        ProductRepository repo = new ProductRepository();
        // GET: Product

        [EnableCors("AllowOrigin")]
        public IHttpActionResult GetProducts()
        {
            var products = repo.GetProducts();

            if (products != null)
                return Ok(products);
            else
                return NotFound();
        }

        public IHttpActionResult PostProduct(Product product)
        {
            var products = repo.SetProduct(product);

            if (products != null)
                return Ok(products);
            else
                return NotFound();
        }

        // ...../api/product/topRatedProducts
        [Route("topRatedProducts")]
        public IHttpActionResult GetTopRatedProduts()
        {
            var topRatedproducts = repo.GetProducts().Where(x => x.Rating > 3).ToList();

            if (topRatedproducts != null)
                return Ok(topRatedproducts);

            return NotFound();
        }
    }
}