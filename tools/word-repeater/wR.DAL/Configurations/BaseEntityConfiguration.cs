using System.Data.Entity.ModelConfiguration;
using wR.Core;

namespace wR.DAL.Configurations
{
    public class BaseEntityConfiguration<T> : EntityTypeConfiguration<T> where T : BaseEntity
    {
        protected BaseEntityConfiguration()
        {
            HasKey(e => e.Id);
        }
    }
}
