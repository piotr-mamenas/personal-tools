using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using wR.Core.Domain;

namespace wR.Web.ViewModels
{
    public class GuessingViewModel
    {
        [Required]
        public Guid TranslationRowGuid { get; set; }

        [Required]
        [DisplayName("Source")]
        public string SourceText { get; set; }

        [Required]
        [DisplayName("Translation")]
        public string TranslatedText { get; set; }

        public bool MarkedCorrect { get; set; }

        public IEnumerable<TranslationRow> AllRowTranslations { get; set; }

        public GuessingViewModel()
        {
            AllRowTranslations = new List<TranslationRow>();
        }
    }
}