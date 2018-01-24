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

        [DisplayName("Source")]
        [Required]
        public string SourceText { get; set; }

        [DisplayName("Translation")]
        [Required]
        public string TranslatedText { get; set; }

        [Required]
        public bool MarkedCorrect { get; set; }

        public IEnumerable<TranslationRow> AllRowTranslations { get; set; }
    }
}