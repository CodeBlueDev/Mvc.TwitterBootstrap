using System.Web.Mvc;

namespace Mvc.TwitterBootstrap3.Web.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

    }
}
