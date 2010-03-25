using System.Web.Mvc;
using GpaHouston.Framework;
using GpaHouston.Models;

namespace GpaHouston.Controllers
{
    public class EventsController : Controller
    {
        public EventsController(IRepository<Event> repository)
        {
            _repository = repository;
        }

        readonly IRepository<Event> _repository;

        public ActionResult Index()
        {
            var events = _repository.GetAll();

            return View(events);
        }

        public ActionResult Create()
        {
            return View("Edit", new Event());
        }

        public ActionResult Edit(long id)
        {
            var model = _repository.GetById(id);

            return View(model);
        }

        [HttpPost]
        public ActionResult Save(Event model)
        {
            _repository.Save(model);

            return RedirectToAction("index");
        }
    }
}