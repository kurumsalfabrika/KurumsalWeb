using Kurumsal.Core.Entities;
using System;

namespace Kurumsal.Entities.Concrete
{
    public class Referans : IEntity
    {
        public int Id { get; set; }

        public int Sira { get; set; }
        public string Baslik { get; set; }
        public string OneCikanGorsel { get; set; }
        public bool Durum { get; set; }
        public bool AnasayfadaGoster { get; set; }
        public bool DetaySayfasiGoster { get; set; }
        public string Icerik { get; set; }
        public string SEOAciklama { get; set; }
        public string SEOKelimeler { get; set; }
        public DateTime Ekleme { get; set; } = DateTime.Now;
    }
}
