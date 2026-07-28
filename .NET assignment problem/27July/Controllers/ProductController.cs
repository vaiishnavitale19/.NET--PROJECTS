using _27July_Assignment.Models;
using Microsoft.AspNetCore.Mvc;

namespace _27July_Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private static List<Product> products = new()
        {
            new Product
            {
                Id = 1,
                Name = "Laptop",
                Price = 65000,
                Category = "Electronics"
            },

            new Product
            {
                Id = 2,
                Name = "Mobile",
                Price = 25000,
                Category = "Electronics"
            },

            new Product
            {
                Id = 3,
                Name = "Shoes",
                Price = 3000,
                Category = "Fashion"
            }
        };

        // GET : api/product
        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok(products);
        }

        // GET : api/product/1
        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);

            if (product == null)
                return NotFound();

            return Ok(product);
        }

        // POST : api/product
        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            products.Add(product);

            return CreatedAtAction(
                nameof(GetProduct),
                new { id = product.Id },
                product
            );
        }

        // PUT : api/product/1
        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id, Product updatedProduct)
        {
            var product = products.FirstOrDefault(p => p.Id == id);

            if (product == null)
                return NotFound();

            product.Name = updatedProduct.Name;
            product.Price = updatedProduct.Price;
            product.Category = updatedProduct.Category;

            return NoContent();
        }

        // DELETE : api/product/1
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);

            if (product == null)
                return NotFound();

            products.Remove(product);

            return NoContent();
        }
    }
}