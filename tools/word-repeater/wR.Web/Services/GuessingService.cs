using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
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
        public async Task<IEnumerable<TranslationRow>> GetTranslations(string languageCode, string sourceText)
        {
            IQueryable<TranslationRow> result;

            switch (languageCode)
            {
                case "EN":
                    result = _context.TranslationRows.Where(tr => tr.English == sourceText);
                    break;

                case "DE":
                    result = _context.TranslationRows.Where(tr => tr.German == sourceText);
                    break;

                case "FR":
                    result = _context.TranslationRows.Where(tr => tr.French == sourceText);
                    break;

                case "PL":
                    result = _context.TranslationRows.Where(tr => tr.Polish == sourceText);
                    break;

                case "ES":
                    result = _context.TranslationRows.Where(tr => tr.Spanish == sourceText);
                    break;

                default:
                    return null;
            }

            return await result.ToListAsync();
        }
    }
}