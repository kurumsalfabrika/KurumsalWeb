using Kurumsal.Core.Entities;
using System;

namespace Kurumsal.Entities.Concrete
{
    public class Yorum : IEntity
    {
        public int Id { get; set; }
        public int Sira { get; set; } = 0;
        public string AdSoyad { get; set; }
        public DateTime YayinTarihi { get; set; }
        public DateTime GuncellemeTarihi { get; set; }
        public string OneCikanGorsel { get; set; }
        public string SEOUrl { get; set; }
        public string SEOAciklama { get; set; }
        public string SEOKelimeler { get; set; }
        public bool Durum { get; set; }
        public string Icerik { get; set; }
        public DateTime Ekleme { get; set; } = DateTime.Now;

    } 
}
