using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurumsal.Domain.Entities.Base
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string? Kod { get; set; }
        public bool IsDeleted { get; set; } = false;

        public Guid? CreatedByUserId { get; set; }
        public Guid? UpdatedByUserId { get; set; }
        public Guid? DeletedByUserId { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        public bool Durum { get; set; } = true;
    }

}
