using System.Collections.Generic;

namespace GpaHouston.Data.Repositories
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        void Save(T item);        
    }
}