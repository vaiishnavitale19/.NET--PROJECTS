using Microsoft.AspNetCore.Mvc;
using _17jul_ShopEase.Models;

namespace _17jul_ShopEase.Controllers
{
    public class ProductController : Controller
    {
        static List<Product> products = new List<Product>();

        public IActionResult Index()
        {
            return View(products);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        } // Open Edit Page
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var product = products.FirstOrDefault(p => p.ProductId == id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // Update Product
        [HttpPost]
        public IActionResult Edit(Product product)
        {
            var existingProduct = products.FirstOrDefault(p => p.ProductId == product.ProductId);

            if (existingProduct != null)
            {
                existingProduct.Name = product.Name;
                existingProduct.Category = product.Category;
                existingProduct.Description = product.Description;
                existingProduct.Price = product.Price;
                existingProduct.Quantity = product.Quantity;
                existingProduct.Brand = product.Brand;
                existingProduct.Discount = product.Discount;
                existingProduct.Rating = product.Rating;
            }

            return RedirectToAction("Index");
        }
        // Delete Product
        public IActionResult Delete(int id)
        {
            var product = products.FirstOrDefault(p => p.ProductId == id);

            if (product != null)
            {
                products.Remove(product);
            }

            return RedirectToAction("Index");
        }
        // Open Search Page
        [HttpGet]
        public IActionResult Search()
        {
            return View();
        }

        // Search Product
        [HttpPost]
        public IActionResult Search(int productId)
        {
            var product = products.FirstOrDefault(p => p.ProductId == productId);

            return View(product);
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            products.Add(product);

            return RedirectToAction("Index");
        }
    }
}