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
    }
}
