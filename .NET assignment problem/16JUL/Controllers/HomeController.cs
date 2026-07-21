using _16jul_assignment.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _16jul_assignment.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }

       