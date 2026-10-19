using Kurumsal.Domain.Entities.Base;

namespace Kurumsal.Domain.Entities
{
    public class Ulke : BaseEntity
    {
        public string Ad { get; set; } = null!;
        public string? TelefonKodu { get; set; }
        public ICollection<Sehir> Sehirler { get; set; } = new List<Sehir>();
    }

}
