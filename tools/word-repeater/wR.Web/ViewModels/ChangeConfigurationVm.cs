using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace wR.Web.ViewModels
{
    public class ChangeConfigurationVm
    {
        public int? Id { get; set; }

        [Required]
        [DisplayName("Source Language")]
        public Guid SourceLanguageId { get; set; }

        [Required]
        [DisplayName("Destination Language")]
        public Guid DestinationLanguageId { get; set; }

        [Required]
        [DisplayName("Flip Mode")]
        public bool IsFlipModeOn { get; set; }

        public IEnumerable<SelectListItem> SourceLanguageSelection { get; set; }

        public IEnumerable<SelectListItem> DestinationLanguageSelection { get; set; }
    }
}