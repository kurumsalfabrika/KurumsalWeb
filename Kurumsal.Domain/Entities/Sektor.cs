using Kurumsal.Domain.Entities.Base;

namespace Kurumsal.Domain.Entities
{
    public class Sektor : BaseEntity
    {
        public string Ad { get; set; } = null!;
        public string? Aciklama { get; set; }
    }
}
