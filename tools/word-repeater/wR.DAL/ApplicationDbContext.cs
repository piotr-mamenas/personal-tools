using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using wR.Core.Domain;

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
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<ForeignKeyIndexConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }
    }
}
