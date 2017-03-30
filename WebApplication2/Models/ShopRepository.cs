using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using WebApplication2.Interfaces;

namespace WebApplication2.Models
{
    public class ShopRepository : IRepository<Shop>
    {
        private ShopContext context;

        public ShopRepository(ShopContext context)
        {
            this.context = context;
        }

        public Shop Get(int id)
        {
            return context.Shops
                .Where(s => s.Id == id)
                .Include(s => s.Products)
                .FirstOrDefault();
        }

        public IEnumerable<Shop> GetAll()
        {
            return context.Shops;
        }
    }
}