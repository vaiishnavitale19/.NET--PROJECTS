using Microsoft.AspNetCore.Mvc;
using AutomobileManagementSystem.Models;

namespace AutomobileManagementSystem.Controllers
{
    public class ManufacturerController : Controller
    {
        public IActionResult Index()
        {
            if (TempData["VehicleName"] == null)
            {
                return RedirectToAction("Register", "Automobile");
            }

            ViewBag.VehicleName = TempData["VehicleName"];
            ViewBag.Brand = TempData["Brand"];

            return View();
        }

        [HttpPost]
        public IActionResult Index(Manufacturer manufacturer)
        {
            ViewBag.VehicleName = TempData["VehicleName"];
            ViewBag.Brand = TempData["Brand"];

            if (ModelState.IsValid)
            {
                return View(manufacturer);
            }

            return View();
        }
    }
}