using Kurumsal.Core.Entities;
using System;

namespace Kurumsal.Entities.Concrete
{
    public class SosyalMedyaAdres : IEntity
    {
        public int Id { get; set; }
        public string Ikon { get; set; }
        public string Ad { get; set; }
        public string Url { get; set; }
        public int? Sira { get; set; } = 0;
        public string Aciklama { get; set; }
        public bool YeniSekmedeAcilsin { get; set; }
        public bool Durum { get; set; }
        public DateTime Ekleme { get; set; } = DateTime.Now;
    }
}
