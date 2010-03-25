using System;
using System.Web.Mvc;
using GpaHouston.Framework;
using StructureMap;

namespace GpaHouston.Controllers
{
    public abstract class CrudController<T> : Controller
        where T : IEntity
    {
        protected CrudController()
        {
            _repository = ObjectFactory.GetInstance<IRepository<T>>();
        }

        readonly IRepository<T> _repository;

        public ActionResult Index()
        {
            var items = _repository.GetAll();

            return View("Index", items);
        }

        public ActionResult Create()
        {
            var t = Activator.CreateInstance<T>();

            return View("Edit", t);
        }

        public ActionResult Edit(long id)
        {
            var model = _repository.GetById(id);

            return View(model);
        }

        [HttpPost]
        public ActionResult Save(T t)
        {
            _repository.Save(t);

            return RedirectToAction("Index");
        }
    }
}