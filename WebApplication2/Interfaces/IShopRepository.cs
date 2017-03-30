using System;
using WebApplication2.Models;

namespace WebApplication2.Interfaces
{
    public interface IShopRepository : IDisposable
    {
        Shop GetShopProduct(int id);
    }
}