using _6Aug.Models;
using _6Aug.Repository;
using Microsoft.AspNetCore.Mvc;

namespace _6Aug.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService service;

        public ProductController(IProductService service)
        {
            this.service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(service.GetProducts());
        }

        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            var product = service.GetProductById(id);

            if (product == null)
            {
                return NotFound("Product is not available");
            }

            return Ok(product);
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            service.AddProduct(product);

            return Ok(product);
        }

        [HttpPut]
        public IActionResult UpdateProduct(Product product)
        {
            var existingProduct = service.GetProductById(product.Id);

            if (existingProduct == null)
            {
                return NotFound("Product is not available");
            }

            service.UpdateProduct(product);

            return Ok("Product Updated Successfully");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var product = service.GetProductById(id);

            if (product == null)
            {
                return NotFound("Product is not available");
            }

            service.DeleteProduct(id);

            return Ok("Product Deleted Successfully");
        }
    }
}