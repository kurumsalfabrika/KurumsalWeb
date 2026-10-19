using Kurumsal.Core.Entities;
using System;

namespace Kurumsal.Entities.Concrete
{
    public class ProjeKategori : IEntity
    {
        public int Id { get; set; }
        public int Sira { get; set; } = 0;
        public string KategoriAdi { get; set; }
        public string OneCikanGorsel { get; set; }
        public string SEOUrl { get; set; }
        public string SEOAciklama { get; set; }
        public string SEOKelimeler { get; set; }
        public bool Durum { get; set; }
        public DateTime Ekleme { get; set; } = DateTime.Now;
    }
}
