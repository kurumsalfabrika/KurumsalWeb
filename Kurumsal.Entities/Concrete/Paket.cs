using Kurumsal.Core.Entities;
using System;

namespace Kurumsal.Entities.Concrete
{
    public class Paket : IEntity
    {
        public int Id { get; set; }
        public int Sira { get; set; }
        public string Baslik { get; set; }
        public string OneCikanGorsel { get; set; }
        public decimal Fiyat { get; set; }
        public int DovizId { get; set; }
        public int PeriyodId { get; set; }
        public bool Durum { get; set; }
        public string SatinAlLink { get; set; }
        public string Ozellikler { get; set; }

        public DateTime Ekleme { get; set; } = DateTime.Now;
    }
}
