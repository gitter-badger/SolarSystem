using System.Linq;
using System.Web.Mvc;
using DAL;

namespace Solar_System.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDataManager _dm;

        public HomeController(IDataManager dataManager)
        {
            _dm = dataManager;
        }

        public ActionResult Index()
        {
            return View(_dm.SpaceObjects.GetAll().ToList());
        }
    }
}
