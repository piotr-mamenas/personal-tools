﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
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

        public GuessingController()
        {
            _context = new ApplicationDbContext();
            _service = new GuessingService(_context);

            _guessingSet = _context.TranslationRows
                .Where(tr => tr.GuessAttempts.Count < 3)
                .ToDictionary(tr => tr.Id);
        }

        [Route(""), HttpGet]
        public ActionResult Index()
        {
            var randomizer = new Random();

            var guessRow = _guessingSet.ElementAt(randomizer.Next(0,_guessingSet.Count)).Value;

            var sourceLanguageGuid = Guid.Parse(ConfigurationManager.AppSettings["SourceLanguage"]);
            var sourceLanguage = _context.Languages.SingleOrDefault(l => l.Id == sourceLanguageGuid);
            
            var guessingVm = new GuessingViewModel
            {
                AllRowTranslations = _service.GetTranslations(sourceLanguage?.Code, guessRow.GetTranslationByLanguageCode(sourceLanguage?.Code)),
                MarkedCorrect = false,
                SourceText = guessRow.GetTranslationByLanguageCode(sourceLanguage?.Code),
                TranslatedText = null,
                TranslationRowGuid = guessRow.Id
            };

            return View(guessingVm);
        }

        [Route("submit"), HttpPost]
        public ActionResult SubmitGuess(GuessingViewModel indexVm)
        {
            return RedirectToAction("Index");
        }
    }
}