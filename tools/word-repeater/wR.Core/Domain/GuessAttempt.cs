using System;

namespace wR.Core.Domain
{
    /// <summary>
    /// An instance of a user attempt of guessing the word defined in destination language
    /// based on the provided source language translation
    /// </summary>
    public class GuessAttempt : BaseEntity
    {
        /// <summary>
        /// The word to be translated
        /// </summary>
        public string SourceText { get; set; }
        public Language SourceLanguage { get; set; }
        public Guid SourceLanguageId { get; set; }

        /// <summary>
        /// User translation of the word
        /// </summary>
        public string TranslatedText { get; set; }
        public Language DestinationLanguage { get; set; }
        public Guid DestinationLanguageId { get; set; }

        public TranslationRow TranslationRow { get; set; }
        public Guid TranslationRowId { get; set; }

        /// <summary>
        /// The time at which the guess was made
        /// </summary>
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// Was the answer marked as correct by the user despite not being identical to possibilities
        /// </summary>
        public bool MarkedCorrect { get; set; }

        /// <summary>
        /// Was the guess identical to what is stored on the database?
        /// </summary>
        public bool Correct { get; set; }
    }
}
