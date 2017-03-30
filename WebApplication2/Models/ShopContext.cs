using System.Data.Entity;

namespace WebApplication2.Models
{
    public class ShopContext : DbContext
    {
        public DbSet<Shop> Shops { get; set; }
    }
}