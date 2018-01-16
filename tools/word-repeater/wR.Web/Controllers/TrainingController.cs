using System.Web.Mvc;
using wR.DAL;

namespace wR.Web.Controllers
{
    [RoutePrefix("training")]
    public class TrainingController : Controller
    {
        [Route("")]
        public ActionResult Index()
        {
            return View();
        }
    }
}