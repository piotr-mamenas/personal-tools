using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using wR.Core.Domain;
using wR.DAL;

namespace wR.Web.Services
{
    public class GuessingService
    {
        private readonly ApplicationDbContext _context;

        public GuessingService(ApplicationDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// The content data is defined in Excel so while not optimal, this solution is the
        /// easiest as there is no need to define column to db handling logic
        /// </summary>
        /// <param name="languageCode">"EN"</param>
        /// <param name="sourceText">"Word"</param>
        /// <returns></returns>
        public IEnumerable<TranslationRow> GetTranslations(string languageCode, string sourceText)
        {
            switch (languageCode)
            {
                case "EN":
                    return _context.TranslationRows.Where(tr => tr.English == sourceText);

                case "DE":
                    return _context.TranslationRows.Where(tr => tr.German == sourceText);

                case "FR":
                    return _context.TranslationRows.Where(tr => tr.French == sourceText);

                case "PL":
                    return _context.TranslationRows.Where(tr => tr.Polish == sourceText);

                case "ES":
                    return _context.TranslationRows.Where(tr => tr.Spanish == sourceText);

                default:
                    return null;
            }
        }
    }
}