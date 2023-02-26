using Microsoft.EntityFrameworkCore;
using TestTask.Models;

namespace TestTask.Models
{
    public class OrderContext : DbContext
    {
        public OrderContext(DbContextOptions<OrderContext> options) 
            : base(options)
        {
        }
        public DbSet<Order> Order { get; set; } = null!;
    }
}
