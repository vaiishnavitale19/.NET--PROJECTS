using _6Aug.Models;
using _6Aug.Repository;
using Microsoft.AspNetCore.Mvc;

namespace _6Aug.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService service;

        public OrderController(IOrderService service)
        {
            this.service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(service.GetOrders());
        }

        [HttpGet("{id}")]
        public IActionResult GetOrder(int id)
        {
            var order = service.GetOrderById(id);

            if (order == null)
            {
                return NotFound("Order is not available");
            }

            return Ok(order);
        }

        [HttpPost]
        public IActionResult AddOrder(Order order)
        {
            service.AddOrder(order);

            return Ok(order);
        }

        [HttpPut]
        public IActionResult UpdateOrder(Order order)
        {
            var existingOrder = service.GetOrderById(order.OrderId);

            if (existingOrder == null)
            {
                return NotFound("Order is not available");
            }

            service.UpdateOrder(order);

            return Ok("Order Updated Successfully");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteOrder(int id)
        {
            var order = service.GetOrderById(id);

            if (order == null)
            {
                return NotFound("Order is not available");
            }

            service.DeleteOrder(id);

            return Ok("Order Deleted Successfully");
        }
    }
}