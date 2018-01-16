using System.Web.Mvc;
using wR.DAL;

namespace wR.Web.Controllers
{
    [RoutePrefix("guessing")]
    public class GuessingController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GuessingController()
        {
            _context = new ApplicationDbContext();
        }

        [Route(""), HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [Route(""), HttpPost]
        public ActionResult SubmitGuess()
        {
            return RedirectToAction("Index");
        }
    }
}