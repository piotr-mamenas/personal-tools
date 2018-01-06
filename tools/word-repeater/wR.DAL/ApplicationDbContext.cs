using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using wR.Core.Domain;
using wR.DAL.Configurations;

namespace wR.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<GuessAttempt> GuessAttempts { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<TranslationRow> TranslationRows { get; set; }

        public ApplicationDbContext()
            : base("wrDB")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<ForeignKeyIndexConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Configurations.Add(new GuessAttemptConfiguration());
            modelBuilder.Configurations.Add(new LanguageConfiguration());
            modelBuilder.Configurations.Add(new TranslationRowConfiguration());
        }
    }
}
