using System.Web.Mvc;
using wR.DAL;

namespace wR.Web.Controllers
{
    [RoutePrefix("")]
    public class HomeController : Controller
    {
        [Route("")]
        public ActionResult Index()
        {
            return View();
        }
    }
}