using Kurumsal.Core.Entities;
using System;

namespace Kurumsal.Entities.Concrete
{
    public class AcilirMesaj : IEntity
    {
        public int Id { get; set; }
        public string OneCikanGorsel { get; set; }
        public string MesajAdi { get; set; }
        public string MesajURL { get; set; }
        public bool BirKereGoster { get; set; } = true;
        public bool ZamanAyarli { get; set; } = false;
        public DateTime? BaslamaTarihi { get; set; }
        public DateTime? BitisTarihi { get; set; }
        public bool YeniSekmedeAcilsin { get; set; }
        public bool Durum { get; set; }
        public string Aciklama { get; set; }
        public DateTime Ekleme { get; set; } = DateTime.Now;
    }
}
