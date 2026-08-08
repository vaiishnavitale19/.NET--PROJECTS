using _6_Aug.Data;
using _6Aug.Models;
using _6Aug.Repository;

namespace _6Aug.Services
{
    public class OrderService : IOrderService
    {
        private readonly AppDbContext context;

        public OrderService(AppDbContext context)
        {
            this.context = context;
        }

        public void AddOrder(Order order)
        {
            context.orders.Add(order);
            context.SaveChanges();
        }

        public void DeleteOrder(int id)
        {
            var order = context.orders.Find(id);

            if (order != null)
            {
                context.orders.Remove(order);
                context.SaveChanges();
            }
        }

        public Order? GetOrderById(int id)
        {
            return context.orders.Find(id);
        }

        public List<Order> GetOrders()
        {
            return context.orders.ToList();
        }

        public void UpdateOrder(Order order)
        {
            context.orders.Update(order);
            context.SaveChanges();
        }
    }
}