using System.Data.Entity.ModelConfiguration;
using wR.Core;

namespace wR.DAL.Configurations
{
    public class BaseEntityConfiguration<T> : EntityTypeConfiguration<T> where T : BaseEntity
    {
        protected BaseEntityConfiguration()
        {
            Property(e => e.IsDeleted).HasColumnName("IsDeleted");

            HasKey(e => e.Id);
        }
    }
}
