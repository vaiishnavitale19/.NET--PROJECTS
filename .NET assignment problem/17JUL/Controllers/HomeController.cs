using Microsoft.AspNetCore.Mvc;

namespace _17jul_ShopEase.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}