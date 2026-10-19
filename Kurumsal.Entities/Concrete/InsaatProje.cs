using Kurumsal.Core.Entities;
using Kurumsal.Entities.Enums;
using System;

namespace Kurumsal.Entities.Concrete
{
    public class InsaatProje : IEntity
    {
        public int Id { get; set; }
        public int Sira { get; set; } = 0;
        public ProjeDurumu ProjeDurumu { get; set; } = ProjeDurumu.Tamamlanmis;
        public string ProjeAdi { get; set; }
        public string ProjeAciklama { get; set; }
        public int? DisGorselId { get; set; }
        public int? IcGorselId { get; set; }
        public int? KrokiGorselId { get; set; }
        public string OneCikanGorsel { get; set; }

        public string SEOUrl { get; set; }
        public string SEOAciklama { get; set; }
        public string SEOKelimeler { get; set; }
        public bool Durum { get; set; }
        public bool AnaSayfadaGoster { get; set; }
        public string SpotMetin { get; set; }
        public string Icerik { get; set; }
        public DateTime Ekleme { get; set; } = DateTime.Now;

    } 
}
