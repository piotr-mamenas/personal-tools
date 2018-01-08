using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web.Mvc;
using wR.DAL;
using wR.Web.ViewModels;

namespace wR.Web.Controllers
{
    [RoutePrefix("configuration")]
    public class ConfigurationController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ConfigurationController()
        {
            _context = new ApplicationDbContext();
        }

        [Route(""), HttpGet]
        public ActionResult Index()
        {
            var changeConfigurationVm = new ChangeConfigurationVm
            {
                SourceLanguageSelection = GetLanguageSelection(),
                SourceLanguageId = Guid.Parse(ConfigurationManager.AppSettings["SourceLanguage"]),
                DestinationLanguageSelection = GetLanguageSelection(),
                DestinationLanguageId = Guid.Parse(ConfigurationManager.AppSettings["DestinationLanguage"]),
                IsFlipModeOn = bool.Parse(ConfigurationManager.AppSettings["FlipMode"])
            };
            return View(changeConfigurationVm);
        }

        [Route(""), HttpPost]
        public ActionResult Change(ChangeConfigurationVm changeViewModel)
        {
            ConfigurationManager.AppSettings["SourceLanguage"] = changeViewModel.SourceLanguageId.ToString();
            ConfigurationManager.AppSettings["DestinationLanguage"] = changeViewModel.DestinationLanguageId.ToString();
            ConfigurationManager.AppSettings["FlipMode"] = changeViewModel.IsFlipModeOn.ToString();

            return RedirectToAction("Index", "Home");
        }

        public IEnumerable<SelectListItem> GetLanguageSelection()
        {
            var languages = _context.Languages.Select(l => new SelectListItem
            {
                Value = l.Id.ToString(),
                Text = l.Code
            });

            return new SelectList(languages, "Value", "Text");
        }
    }
}