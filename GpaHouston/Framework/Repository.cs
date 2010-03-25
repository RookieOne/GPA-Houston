using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Db4objects.Db4o;
using Db4objects.Db4o.Linq;

namespace GpaHouston.Framework
{
    public class Repository<T> : IDisposable, IRepository<T> where T : IEntity
    {
        public Repository(IObjectContainer database)
        {
            _database = database;
        }

        readonly IObjectContainer _database;

        public void Dispose()
        {
            _database.Dispose();
        }

        public IEnumerable<T> GetAll()
        {
            return _database.Query<T>();
        }

        public void Save(T item)
        {
            _database.Store(item);
            _database.Commit();

            if (item.Id == 0)
            {
                item.Id = _database.Ext().GetID(item);
                _database.Store(item);
                _database.Commit();                
            }
        }

        public void Save<M>(M model) where M : IEntity
        {
            var t = GetById(model.Id);

            Mapper.Map(model, t);

            Save(t);
        }

        public M GetById<M>(long id)
        {
            var t = GetById(id);

            return Mapper.Map<T,M>(t);
        }

        public T GetById(long id)
        {
            var item = (from T t in _database
                        where t.Id == id
                        select t).FirstOrDefault();

            return (item != null)
                       ? item
                       : Activator.CreateInstance<T>();
        }
    }
}