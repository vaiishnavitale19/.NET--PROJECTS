using _29July.Models;
using _29July.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _29July.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly IVehicleService _service;

        public VehicleController(IVehicleService service)
        {
            _service = service;
        }

        // GET : api/Vehicle
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.GetVehicles());
        }

        // GET : api/Vehicle/1
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var vehicle = _service.GetVehicle(id);

            if (vehicle == null)
            {
                return NotFound("Vehicle not found");
            }

            return Ok(vehicle);
        }

        // POST : api/Vehicle
        [HttpPost]
        public IActionResult AddVehicle(Vehicle vehicle)
        {
            var result = _service.AddVehicle(vehicle);
            return Ok(result);
        }
    }
}
