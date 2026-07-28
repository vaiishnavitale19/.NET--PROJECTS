using _28July.Models;
using _28July.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _28July.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _service;

        public ProductController(IProductService service)
        {
            _service = service;
        }

        // GET : api/products
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_service.GetAll());
        }

        // GET : api/products/1
        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            var product = _service.GetById(id);

            if (product == null)
                return NotFound("Product not found");

            return Ok(product);
        }

        // POST : api/products
        [HttpPost]
        public IActionResult Create(Product product)
        {
            var created = _service.AddProduct(product);

            return Ok(created);
        }

        // PUT : api/products/1
        [HttpPut("{id}")]
        public IActionResult Update(int id, Product product)
        {
            var updated = _service.UpdateProduct(id, product);

            if (updated == null)
                return NotFound("Product not found");

            return Ok(updated);
        }

        // DELETE : api/products/1
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            bool deleted = _service.DeleteProduct(id);

            if (!deleted)
                return NotFound("Product not found");

            return NoContent();
        }
    }
}

