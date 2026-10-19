using Kurumsal.Core.Entities;
using System;

namespace Kurumsal.Entities.Concrete
{
	public class Slider : IEntity
    {
        public int Id { get; set; }
        public int Sira { get; set; } = 0;
        public string SliderBaslik { get; set; }
        public string IkinciSatir { get; set; }
        public string UcuncuSatir { get; set; }
        public string DorduncuSatir { get; set; }
        public bool YeniSekmedeAc { get; set; } = false;
        public string OneCikanGorsel { get; set; }
        public string OneCikanGorsel1 { get; set; }
        public string OneCikanGorsel2 { get; set; }
        public string Aciklama { get; set; }
        public string SliderURL { get; set; }
        public string ButonYazisi { get; set; }
        public string SEOUrl { get; set; }
        public string SEOAciklama { get; set; }
        public string SEOKelimeler { get; set; }
        public bool Durum { get; set; }
        public DateTime Ekleme { get; set; } = DateTime.Now;
    }
}
