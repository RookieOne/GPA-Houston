using System.Collections.Generic;
using GpaHouston.Data.Dtos;

namespace GpaHouston.Data.Repositories
{
    public interface IRepository<T> where T : IEntity
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        void Save(T item);
    }
}