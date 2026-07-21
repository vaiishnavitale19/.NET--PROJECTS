using Microsoft.AspNetCore.Mvc;
using _17jul_ShopEase.Models;

namespace _17jul_ShopEase.Controllers
{
    public class CategoryController : Controller
    {
        static List<Category> categories = new List<Category>();

        // Display Categories
        public IActionResult Index()
        {
            return View(categories);
        }

        // Open Add Category Page
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        // Open Edit Page
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var category = categories.FirstOrDefault(c => c.CategoryId == id);

            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // Update Category
        [HttpPost]
        public IActionResult Edit(Category category)
        {
            var existingCategory = categories.FirstOrDefault(c => c.CategoryId == category.CategoryId);

            if (existingCategory != null)
            {
                existingCategory.CategoryName = category.CategoryName;
            }

            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var category = categories.FirstOrDefault(c => c.CategoryId == id);

            if (category != null)
            {
                categories.Remove(category);
            }

            return RedirectToAction("Index");
        }

        // Save Category
        [HttpPost]
        public IActionResult Create(Category category)
        {
            categories.Add(category);

            return RedirectToAction("Index");
        }
    }
}