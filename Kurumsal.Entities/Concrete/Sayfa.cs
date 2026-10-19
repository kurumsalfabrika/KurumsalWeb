using Kurumsal.Core.Entities;
using System;

namespace Kurumsal.Entities.Concrete
{
    public class Sayfa : IEntity
    {
        public int Id { get; set; }
        public string Baslik { get; set; }
        public string OneCikanGorsel { get; set; }
        public int? BaglantiSayfasiId { get; set; }
        public int? SayfaKategoriId { get; set; }
        public SayfaKategori SayfaKategori { get; set; }
        public bool Durum { get; set; }
        public bool AnasayfadaGozuksun { get; set; }
        public string SpotMetin { get; set; }
        public string Icerik { get; set; }
        public string ListeKodu { get; set; }
        public string SEOAciklama { get; set; }
        public string SEOKelimeler { get; set; }
        public DateTime Ekleme { get; set; } = DateTime.Now;
    }
}
