using System.ComponentModel.DataAnnotations.Schema;
using wR.Core.Domain;

namespace wR.DAL.Configurations
{
    public class GuessAttemptConfiguration : BaseEntityConfiguration<GuessAttempt>
    {
        public GuessAttemptConfiguration()
        {
            ToTable("GuessAttempts");

            Property(ga => ga.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnName("GuessAttemptId");

            HasRequired(ga => ga.SourceLanguage)
                .WithMany()
                .HasForeignKey(ga => ga.SourceLanguageId);

            Property(ga => ga.SourceContent)
                .HasColumnName("GuessSource")
                .IsRequired();

            HasRequired(ga => ga.TranslationRow)
                .WithMany(tr => tr.GuessAttempts)
                .HasForeignKey(ga => ga.TranslationRowId);

            HasRequired(ga => ga.DestinationLanguage)
                .WithMany()
                .HasForeignKey(ga => ga.DestinationLanguageId);

            Property(ga => ga.DestinationContent)
                .HasColumnName("GuessDestination")
                .IsRequired();

            Property(ga => ga.MarkedAsCorrect)
                .HasColumnName("IsMarkedAsCorrect")
                .IsRequired();

            Property(ga => ga.MeaningRetained)
                .HasColumnName("IsMeaningRetained")
                .IsRequired();

            Property(ga => ga.Correct)
                .HasColumnName("WasCorrectlyAnswered")
                .IsRequired();

            Property(ga => ga.Timestamp)
                .HasColumnType("datetime2")
                .HasColumnName("GuessedTime")
                .IsRequired();
        }
    }
}
