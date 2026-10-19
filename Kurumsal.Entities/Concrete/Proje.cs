using Kurumsal.Core.Entities;
using System;

namespace Kurumsal.Entities.Concrete
{
    public class Proje : IEntity
    {
        public int Id { get; set; }
        public int Kategori { get; set; } = 0;
        public int Sira { get; set; } = 0;
        public string Baslik { get; set; }
        public string YoutubeID { get; set; }
        public DateTime YayinTarihi { get; set; }
        public DateTime GuncellemeTarihi { get; set; }
        public string OneCikanGorsel { get; set; }
        public int FotoGaleriId { get; set; }
        public bool Durum { get; set; }
        public bool AnasayfadaGozuksun{ get; set; }
        public string SpotMetin { get; set; }
        public string Icerik { get; set; }
        public string SEOAciklama { get; set; }
        public string SEOKelimeler { get; set; }
        public DateTime Ekleme { get; set; } = DateTime.Now;
    }
}
