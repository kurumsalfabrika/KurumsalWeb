using Kurumsal.Core.Entities;
using System;

namespace Kurumsal.Entities.Concrete
{
    public class BankaHesap : IEntity
    {
        public int Id { get; set; }
        public int Sira { get; set; } = 0;
        public string HesapAdi { get; set; }
        public string SubeKoduSubeAdi { get; set; }
        public string HesapNumarasi { get; set; }
        public string IBAN { get; set; }
        public string BankaLogo { get; set; }
        public string SEOUrl { get; set; }
        public string SEOAciklama { get; set; }
        public string SEOKelimeler { get; set; }
        public bool Durum { get; set; }
        public DateTime Ekleme { get; set; } = DateTime.Now;
    }
}
