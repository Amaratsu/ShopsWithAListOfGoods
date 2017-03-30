﻿namespace WebApplication2.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int ShopId { get; set; }
        public Shop Shop { get; set; }
    }
}