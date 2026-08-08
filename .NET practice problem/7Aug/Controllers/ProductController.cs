using _7Aug.Models;
using _7Aug.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _7Aug.Controllers
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
        public IActionResult GetProduct()
        {
            return Ok(service.GetProducts());
        }

        [HttpGet("/id")]

        public IActionResult GetId(int id)
        {
            var product = service.GetProductById(id);

            if (product == null)
            {
                NotFound("Product is not available");
            }
            return Ok(product);
        }

        [HttpPost]
        public IActionResult AddP(Product product)
        {
            service.AddProduct(product);
            return Ok(product);
        }



    }
}
