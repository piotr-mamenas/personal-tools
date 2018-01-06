using System.ComponentModel.DataAnnotations.Schema;
using wR.Core.Domain;

namespace wR.DAL.Configurations
{
    public class LanguageConfiguration : BaseEntityConfiguration<Language>
    {
        public LanguageConfiguration()
        {
            ToTable("Languages");

            Property(ga => ga.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnName("LanguageId");

            Property(l => l.Name).HasColumnName("LanguageName");

            Property(l => l.Code).HasColumnName("LanguageCode");
        }
    }
}
