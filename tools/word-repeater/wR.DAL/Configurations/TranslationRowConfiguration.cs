using System.ComponentModel.DataAnnotations.Schema;
using wR.Core.Domain;

namespace wR.DAL.Configurations
{
    public class TranslationRowConfiguration : BaseEntityConfiguration<TranslationRow>
    {
        public TranslationRowConfiguration()
        {
            ToTable("TranslationRow");

            Property(a => a.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnName("TranslationRowId");

            Property(tr => tr.English)
                .HasColumnName("EnglishTranslation");

            Property(tr => tr.German)
                .HasColumnName("GermanTranslation");

            Property(tr => tr.French)
                .HasColumnName("FrenchTranslation");

            Property(tr => tr.Italian)
                .HasColumnName("ItalianTranslation");

            Property(tr => tr.Polish)
                .HasColumnName("PolishTranslation");

            Property(tr => tr.Spanish)
                .HasColumnName("SpanishTranslation");

            HasMany(tr => tr.GuessAttempts)
                .WithRequired(ga => ga.TranslationRow)
                .HasForeignKey(ga => ga.TranslationRowId);
        }
    }
}
