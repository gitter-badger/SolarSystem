using System.Linq;
using System.Web.Mvc;
using AutoMapper;
using Model;
using Model.Models;
using Solar_System.Models;

namespace Solar_System.Controllers
{
    public class HomeController : Controller
    {
        private readonly SolarSystemContext _dm;

        public HomeController()
        {
            _dm = new SolarSystemContext();
        }

        public ActionResult Index()
        {
            var spaceObjects = _dm.SpaceObjects.ToList();
            var model = spaceObjects.Select(Mapper.Map<SpaceObject, SpaceObjectViewModel>);

            return View(model);
        }
    }
}
