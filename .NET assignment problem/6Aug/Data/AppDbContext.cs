
using _6Aug.Models;
using Microsoft.EntityFrameworkCore;

namespace _6_Aug.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> products { get; set; }

        public DbSet<Order> orders { get; set; }
    }
}