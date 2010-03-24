using System.Linq;
using Db4objects.Db4o;
using GpaHouston.Data.Dtos;
using GpaHouston.Data.Repositories;
using NUnit.Framework;

namespace GpaHouston.Data.Tests
{
    [TestFixture]
    public class RepositoryTests
    {
        IObjectContainer GetContainer()
        {
            var container = Db4oEmbedded.OpenFile(Db4oEmbedded.NewConfiguration(), "testDb");
            container.Store(new Foo {Id = 1, Bar = "1"});
            container.Store(new Foo {Id = 2, Bar = "2"});
            container.Store(new Foo {Id = 3, Bar = "3"});
            container.Commit();

            return container;
        }

        [Test]
        public void get_all_should_return_collection_of_items()
        {
            using (var container = GetContainer())
            {
                var repository = new Repository<Foo>(container);

                var items = repository.GetAll();

                items.Count().ShouldNotBe(0);
            }
        }

        [Test]
        public void get_by_id_should_retrieve_object_from_container()
        {
            using (var container = GetContainer())
            {
                var repository = new Repository<Foo>(container);

                var foo = repository.GetById(1);

                foo.ShouldNotBeNull();
            }
        }

        [Test]
        public void save_should_store_object_in_container()
        {
            using (var container = GetContainer())
            {
                var repository = new Repository<Foo>(container);

                var foo = new Foo {Id = 13, Bar = "Test"};

                repository.Save(foo);

                var items = repository.GetAll();
                items.Any(f => f.Id == foo.Id).ShouldBeTrue();
            }
        }
    }

    internal class Foo : IEntity
    {
        public string Bar { get; set; }
        public int Id { get; set; }
    }
}