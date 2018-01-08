using System.Web.Mvc;

namespace wR.Web.Controllers
{
    [RoutePrefix("guessing")]
    public class GuessingController : Controller
    {
        [Route(""), HttpGet]
        public ActionResult Index()
        {
            return View();
        }
    }
}