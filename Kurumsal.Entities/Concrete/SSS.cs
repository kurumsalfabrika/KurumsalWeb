using Kurumsal.Core.Entities;
using System;

namespace Kurumsal.Entities.Concrete
{
    public class SSS : IEntity
    {
        public int Id { get; set; }
        public int Sira { get; set; }
        public int? SSSKategoriId { get; set; }
        public SSSKategori SSSKategori { get; set; }
        public string SoruAdi { get; set; }
        public bool Durum { get; set; }
        public string Icerik { get; set; }
        public string SEOAciklama { get; set; }
        public string SEOKelimeler { get; set; }
        public DateTime Ekleme { get; set; } = DateTime.Now;
    } 
}
