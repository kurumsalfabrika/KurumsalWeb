using Kurumsal.Core.Entities;
using System;

namespace Kurumsal.Entities.Concrete
{
    public class Oda : IEntity
    {
        public int Id { get; set; }
        public int Sira { get; set; } = 0;
        public int? OdaKategoriId { get; set; }
        public OdaKategori OdaKategori { get; set; }
        public string OdaAdi { get; set; }
        public int MaxYetiskin { get; set; } = 0;
        public int MaxCocuk { get; set; } = 0;
        public int? FotoGaleriId { get; set; }
        public FotoGaleri FotoGaleri { get; set; }
        public string OdaGenislik { get; set; }
        public string YatakSayisi { get; set; }
        public string OneCikanGorsel { get; set; }
        public string SEOUrl { get; set; }
        public string SEOAciklama { get; set; }
        public string SEOKelimeler { get; set; }
        public string SpotMetin { get; set; }
        public string Icerik { get; set; }
        public decimal GunlukUcret { get; set; } = 0;
        public decimal GunlukUcret1 { get; set; } = 0;
        public decimal GunlukUcret2 { get; set; } = 0;
        public decimal GunlukUcret3 { get; set; } = 0;
        public DateTime Ekleme { get; set; } = DateTime.Now;

    } 
}
