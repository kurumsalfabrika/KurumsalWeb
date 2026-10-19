using Kurumsal.Core.Entities;
using System;

namespace Kurumsal.Entities.Concrete
{
    public class VideoGaleri : IEntity
    {
        public int Id { get; set; }
        public int Sira { get; set; } = 0;
        public string GaleriAdi { get; set; }
        public string YoutubeId { get; set; }
        public string OneCikanGorsel { get; set; }
        public string SEOUrl { get; set; }
        public string SEOAciklama { get; set; }
        public string SEOKelimeler { get; set; }
        public string Icerik { get; set; }
        public bool Durum { get; set; }
        public DateTime Ekleme { get; set; } = DateTime.Now;
    }
}
