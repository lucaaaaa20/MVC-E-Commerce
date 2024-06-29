using Microsoft.EntityFrameworkCore;
using MVCECommerce.Models;

namespace MVCECommerce.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Article> Article { get; set; }
        public DbSet<Brand> Brand { get; set; }
        public DbSet<Cart> Cart { get; set; }
        public DbSet<CartArticle> CartArticle { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<ClientData> ClientData { get; set; }
        public DbSet<Color> Color { get; set; }
        public DbSet<DeliveryStatus> DeliveryStatus { get; set; }
        public DbSet<Group> Group { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderStatus> OrderStatus { get; set; }
        public DbSet<Size> Size { get; set; }
        public DbSet<Variant> Variant { get; set; }
    }
}
