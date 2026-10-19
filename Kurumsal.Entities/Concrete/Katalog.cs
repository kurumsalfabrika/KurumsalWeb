using Kurumsal.Core.Entities;
using System;

namespace Kurumsal.Entities.Concrete
{
    public class Katalog : IEntity
    {
        public int Id { get; set; }
        public int KatalogKategoriId { get; set; } = 0;
        public int Sira { get; set; } = 0;
        public string OneCikanGorsel { get; set; }
        public string Dosya { get; set; }
        public string Baslik { get; set; }
        public bool Durum { get; set; }
        public DateTime Ekleme { get; set; } = DateTime.Now;
    }
}
