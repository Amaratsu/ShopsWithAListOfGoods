using System;

namespace WebApplication2.Models
{
    public class UnitOfWork
    {
        private ShopContext context = new ShopContext();
        private ShopRepository _shopRepository;

        public ShopRepository Shops
        {
            get
            {
                if (_shopRepository == null)
                    _shopRepository = new ShopRepository(context);
                return _shopRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool _disposed;

        public virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
                _disposed = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}