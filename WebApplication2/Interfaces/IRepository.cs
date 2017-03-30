using System.Collections.Generic;

namespace WebApplication2.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Get(int id);
    }
}