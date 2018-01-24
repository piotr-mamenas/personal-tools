using System;
using System.Collections.Generic;

namespace wR.Core.Domain
{
    /// <summary>
    /// A row containing potential translation of a word or sentence between different
    /// languages
    /// </summary>
    public class TranslationRow : BaseEntity
    {
        public string English { get; set; }

        public string German { get; set; }

        public string French { get; set; }

        public string Polish { get; set; }

        public string Spanish { get; set; }

        public string Italian { get; set; }

        public ICollection<GuessAttempt> GuessAttempts { get; set; }

        public string GetTranslationByLanguageCode(string code)
        {
            switch (code)
            {
                case "EN":
                    return English;

                case "DE":
                    return German;

                case "FR":
                    return French;

                case "PL":
                    return Polish;

                case "ES":
                    return Spanish;

                default:
                    throw new ArgumentException($"Could not find Key: {code}");
            }
        }
    }
}
