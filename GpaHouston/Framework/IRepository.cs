using System.Collections.Generic;

namespace GpaHouston.Framework
{
    public interface IRepository<T> where T : IEntity
    {
        T GetById(long id);
        IEnumerable<T> GetAll();
        void Save(T item);
    }
}