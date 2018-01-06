using System;

namespace wR.Core
{
    public class BaseEntity
    {
        public Guid Id { get; set; }

        public bool IsDeleted { get; set; }

        public BaseEntity()
        {
            IsDeleted = true;
        }
    }
}
