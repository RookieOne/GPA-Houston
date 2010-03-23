using System;
using System.Collections.Generic;
using System.Linq;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Linq;

namespace GpaHouston.Data.Repositories
{
    public class Repository<T> : IRepository<T>
    {
        public Repository()
        {
            var factory = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2008.ConnectionString(c => c.Database("GpaHouston")
                                                                                 .Server("thecoder")
                                                                                 .TrustedConnection()))
                .BuildSessionFactory();
            _session = factory.OpenSession();
        }

        ISession _session;

        public IEnumerable<T> GetAll()
        {
            return from t in _session.Linq<T>()
                   select t;
        }

        public void Save(T item)
        {
            throw new NotImplementedException();
        }
    }
}