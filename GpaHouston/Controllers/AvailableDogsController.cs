using System.Web.Mvc;
using GpaHouston.Data.Dtos;
using GpaHouston.Data.Repositories;
using GpaHouston.Models;

namespace GpaHouston.Controllers
{
    public class AvailableDogsController : Controller
    {
        public AvailableDogsController(IRepository<AvailableDog> repository)
        {
            _repository = repository;
        }

        readonly IRepository<AvailableDog> _repository;

        public ActionResult Index()
        {
            ViewData["AvailableDogs"] = _repository.GetAll();

            return View();
        }

        [HttpGet]
        public ActionResult New()
        {            
            return View(new AvailableDogModel());
        }
        
        [HttpPost]        
        public ActionResult New()
        {
            return View();
        }
    }
}