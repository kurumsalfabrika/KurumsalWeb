using Kurumsal.Domain.Entities.Base;

namespace Kurumsal.Domain.Entities
{
    public class Sehir : BaseEntity
    {
        public string Ad { get; set; } = null!;
        public string? TelefonKodu { get; set; } 
        public Guid UlkeId { get; set; }
        public Ulke Ulke { get; set; } = null!;
        public ICollection<Ilce> Ilceler { get; set; } = new List<Ilce>();
    }

}
