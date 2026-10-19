using Kurumsal.Domain.Entities.Base;

namespace Kurumsal.Domain.Entities
{
    public class Ilce : BaseEntity
    {
        public string Ad { get; set; } = null!;
        public Guid SehirId { get; set; }
        public Sehir Sehir { get; set; } = null!;
    }

}
