using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using wR.Core.Domain;
using wR.DAL;
using wR.Web.Services;
using wR.Web.ViewModels;

namespace wR.Web.Controllers
{
    [RoutePrefix("guessing")]
    public class GuessingController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly GuessingService _service;
        private readonly IDictionary<Guid, TranslationRow> _guessingSet;
        private readonly Guid _sourceLanguageGuid;
        private readonly Guid _targetLanguageGuid;

        public GuessingController()
        {
            _context = new ApplicationDbContext();
            _service = new GuessingService(_context);

            _guessingSet = _context.TranslationRows
                .Where(tr => tr.GuessAttempts.Count < 3)
                .ToDictionary(tr => tr.Id);

            _sourceLanguageGuid = Guid.Parse(ConfigurationManager.AppSettings["SourceLanguage"]);
            _targetLanguageGuid = Guid.Parse(ConfigurationManager.AppSettings["DestinationLanguage"]);
        }

        [Route(""), HttpGet]
        public async Task<ActionResult> Index()
        {
            var randomizer = new Random();
            var guessRow = _guessingSet.ElementAt(randomizer.Next(0,_guessingSet.Count-1)).Value;
            
            var sourceLanguage = await _context.Languages.SingleOrDefaultAsync(l => l.Id == _sourceLanguageGuid);
            
            var guessingVm = new GuessingViewModel
            {
                AllRowTranslations = await _service.GetTranslations(sourceLanguage?.Code, guessRow.GetTranslationByLanguageCode(sourceLanguage?.Code)),
                MarkedCorrect = false,
                SourceText = guessRow.GetTranslationByLanguageCode(sourceLanguage?.Code),
                TranslatedText = null,
                TranslationRowGuid = guessRow.Id
            };

            return View(guessingVm);
        }

        [Route("submit"), HttpPost]
        public async Task<ActionResult> SubmitGuess(string checkButton, string forceButton, GuessingViewModel indexVm)
        {
            if (!ModelState.IsValid)
            {
                return View("Index",indexVm);
            }

            if (checkButton != null)
            {
                indexVm.MarkedCorrect = false;
            }
            else
            {
                indexVm.MarkedCorrect = true;
            }

            var sourceLanguage = await _context.Languages.SingleOrDefaultAsync(l => l.Id == _sourceLanguageGuid);
            var targetLanguage = await _context.Languages.SingleOrDefaultAsync(l => l.Id == _targetLanguageGuid);

            foreach (var translation in indexVm.AllRowTranslations)
            {
                var correctTranslation = translation.GetTranslationByLanguageCode(targetLanguage.Code);
                indexVm.CorrectlyTranslatedText = correctTranslation;

                if (indexVm.TranslatedText == correctTranslation)
                {
                    var successfulGuess = new GuessAttempt();
                    _context.GuessAttempts.Add(successfulGuess.GetGuessAttempt(indexVm.SourceText,
                        indexVm.TranslatedText,
                        sourceLanguage,
                        targetLanguage,
                        translation.Id,
                        true,
                        indexVm.MarkedCorrect));
                    
                    await _context.SaveChangesAsync();

                    return RedirectToAction("Index");
                }
                else
                {
                    var failedGuess = new GuessAttempt();
                    _context.GuessAttempts.Add(failedGuess.GetGuessAttempt(indexVm.SourceText,
                        indexVm.TranslatedText,
                        sourceLanguage,
                        targetLanguage,
                        indexVm.TranslationRowGuid,
                        false,
                        indexVm.MarkedCorrect));

                    await _context.SaveChangesAsync();
                }
            }
            indexVm.TranslatedText = null;
            indexVm.MarkedCorrect = false;
            return View("Index", indexVm);
        }
    }
}