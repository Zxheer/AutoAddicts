using System.Data.Entity;
namespace AutoAddicts.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("AutoAddicts")
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<CartItem> ShoppingCartItems { get; set; }
        public DbSet<Sold> Sold { get; set; }
    }
}