using System.Linq;
using System.Web.Mvc;
using DAL;
using Model;

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
            var model = _dm.SpaceObjects.ToList();
            


            return View(model);
        }
    }
}
