using System.IO;
using System.Reflection;
using Db4objects.Db4o;
using GpaHouston.Data.Repositories;
using StructureMap;

namespace GpaHouston.Framework
{
    public class Bootstrapper
    {
        public const string DB4O_FILENAME = "gpaHouston";

        static string DbPath
        {
            get
            {
                return Path.Combine(Path.GetDirectoryName(Assembly.GetAssembly(typeof (Bootstrapper)).Location),
                                    DB4O_FILENAME);
            }
        }

        public static void Config()
        {
            ObjectFactory.Configure(Configure);
        }

        static void Configure(ConfigurationExpression x)
        {
            x.AddRegistry(new MyAppRegistry());

            x.For<IObjectContainer>()
                .Singleton()
                .Use(Db4oEmbedded.OpenFile(Db4oEmbedded.NewConfiguration(), DbPath));

            x.For(typeof (IRepository<>))
                .Use(typeof (Repository<>));
        }
    }
}