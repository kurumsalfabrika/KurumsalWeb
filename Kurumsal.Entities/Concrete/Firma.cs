using Kurumsal.Core.Entities;
using System;

namespace Kurumsal.Entities.Concrete
{
    public class Firma : IEntity
    {
        public int Id { get; set; }
        public string FirmaUnvani { get; set; }
        public string Yetkili { get; set; }
        public string Telefon { get; set; }
        public string Gsm { get; set; }
        public string Faks { get; set; }
        public string Adres { get; set; }
        public string Ulke { get; set; }
        public string Sehir { get; set; }
        public string Ilce { get; set; }
        public string VergiDairesi { get; set; }
        public string VergiNo { get; set; }
        public string TCKimlikNo { get; set; }

        public DateTime BaslamaTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }

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
