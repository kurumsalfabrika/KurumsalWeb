using Kurumsal.Core.Entities;
using System;

namespace Kurumsal.Entities.Concrete
{
    public class Marka : IEntity
    {
        public int Id { get; set; }
        public int MarkaSira { get; set; } = 1;
        public string MarkaAdi { get; set; }
        public string OneCikanGorsel { get; set; }
        public string MenuAciklama { get; set; }
        public string SEOUrl { get; set; }
        public string SEOAciklama { get; set; }
        public string SEOKelimeler { get; set; }
        public bool Durum { get; set; }
        public DateTime Ekleme { get; set; } = DateTime.Now;
    } 
}
