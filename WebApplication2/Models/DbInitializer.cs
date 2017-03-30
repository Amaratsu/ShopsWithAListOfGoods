using System.Collections.Generic;
using System.Data.Entity;

namespace WebApplication2.Models
{
    public class DbInitializer : DropCreateDatabaseAlways<ShopContext>
    {
        protected override void Seed(ShopContext db)
        {
            Product product1 = new Product
            {
                Id = 1,
                Name = "Холодильник ATLANT ХМ 4214-000",
                Description = "без No Frost, механическое управление, класс A, полезный объём: 234 л (167 + 67 л), 54.5x60x180.5 см, белый"
            };
            Product product2 = new Product
            {
                Id = 2,
                Name = "Холодильник Samsung RB33J3420BC",
                Description = "полный No Frost, электронное управление, класс A+, полезный объём: 328 л (230 + 98 л), инверторный компрессор, 59.5x66.8x185 см, черный"
            };
            Product product3 = new Product
            {
                Id = 3,
                Name = "Bosch GBH 2-26 DFR Professional (0611254768)",
                Description = "800 Вт, питание: сеть, 4000 ударов/мин, энергия удара: 2.7 Дж, 2900 г"
            };
            Product product4 = new Product
            {
                Id = 4,
                Name = "Lenovo Tab 2 A10-70F 16GB Blue (ZA000012PL)",
                Description = "10,1 IPS (1920x1200), Android, ОЗУ 2 ГБ, флэш-память 16 ГБ, цвет синий/черный"
            };

            Shop shop1 = new Shop
            {
                Id = 1,
                Name = "Атлант",
                Address = "Ул. Притыцкого, 27А",
                Mode = "10 00 - 23 00",
                Products = new List<Product> { product1 }
            };
            Shop shop2 = new Shop
            {
                Id = 2,
                Name = "Ома",
                Address = "Пр. Победителей, 29",
                Mode = "9 00 - 22 00",
                Products = new List<Product> { product3 }
            };
            Shop shop3 = new Shop
            {
                Id = 3,
                Name = "5 Элемент",
                Address = "Ул. Московская, 11",
                Mode = "9 00 - 23 00",
                Products = new List<Product> { product2, product4 }
            };

            db.Shops.Add(shop1);
            db.Shops.Add(shop2);
            db.Shops.Add(shop3);

            base.Seed(db);
        }
    }
}