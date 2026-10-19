using Kurumsal.Core.Entities;
using System;
using System.Collections.Generic;

namespace Kurumsal.Entities.Concrete
{
    public class FotoGaleri : IEntity
    {
        public int Id { get; set; }
        public int Sira { get; set; } = 0;
        public string GaleriAdi { get; set; }
        public string OneCikanGorsel { get; set; }
        public string SEOUrl { get; set; }
        public string SEOAciklama { get; set; }
        public string SEOKelimeler { get; set; }
        public string Icerik { get; set; }
        public string ListeKodu { get; set; }
        public bool Durum { get; set; }
        public DateTime Ekleme { get; set; } = DateTime.Now;
        public IEnumerable<Oda> Odalar { get; set; }
        public IEnumerable<Fotograf> Fotograflar { get; set; }
    }
}
