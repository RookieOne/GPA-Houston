using System;
using System.Collections.Generic;
using System.Linq;
using Db4objects.Db4o;
using Db4objects.Db4o.Linq;
using GpaHouston.Data.Dtos;

namespace GpaHouston.Data.Repositories
{
    public class Repository<T> : IDisposable, IRepository<T> where T : IEntity
    {
        public Repository(IObjectContainer database)
        {
            _database = database;
        }

        readonly IObjectContainer _database;

        public T GetById(int id)
        {
            return (from T t in _database
                    where t.Id == id
                    select t).FirstOrDefault();
        }

        public IEnumerable<T> GetAll()
        {
            return _database.Query<T>();
        }

        public void Save(T item)
        {
            _database.Store(item);
            _database.Commit();
        }

        public void Dispose()
        {
            _database.Dispose();
        }
    }
}