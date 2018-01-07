using System.Web.Mvc;
using wR.DAL;

namespace wR.Web.Controllers
{
    [RoutePrefix("")]
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        
        public HomeController()
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