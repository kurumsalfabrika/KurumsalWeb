using Kurumsal.Core.Entities;
using System;

namespace Kurumsal.Entities.Concrete
{
    public class Sube : IEntity
    {
        public int Id { get; set; }
        public int Sira { get; set; } = 0;
        public string SubeAdi { get; set; }
        public int? FotoGaleriId { get; set; }
        public FotoGaleri FotoGaleri { get; set; }
        public string OneCikanGorsel { get; set; }
        public string Adres { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }
        public string Telefon { get; set; }
        public string GSM { get; set; }
        public string Eposta { get; set; }
        public string SEOUrl { get; set; }
        public string SEOAciklama { get; set; }
        public string SEOKelimeler { get; set; }
        public string Icerik { get; set; }
        public bool Durum { get; set; }
        public DateTime Ekleme { get; set; } = DateTime.Now;
    }
}
