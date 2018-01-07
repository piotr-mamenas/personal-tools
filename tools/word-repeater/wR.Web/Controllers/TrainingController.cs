using System.Web.Mvc;
using wR.DAL;

namespace wR.Web.Controllers
{
    [RoutePrefix("training")]
    public class TrainingController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TrainingController()
        {
            _context = new ApplicationDbContext();
        }

        [Route("")]
        public ActionResult Index()
        {
            return View();
        }
    }
}