using System;
using System.Collections.Generic;
using System.ComponentModel;
using wR.Core.Domain;

namespace wR.Web.ViewModels
{
    public class GuessingViewModel
    {
        public Guid TranslationRowGuid { get; set; }

        [DisplayName("Source")]
        public string SourceText { get; set; }

        [DisplayName("Translation")]
        public string TranslatedText { get; set; }

        public bool MarkedCorrect { get; set; }

        public IEnumerable<TranslationRow> AllRowTranslations { get; set; }
    }
}