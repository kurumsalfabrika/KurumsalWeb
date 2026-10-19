using Kurumsal.Core.Entities;
using System;

namespace Kurumsal.Entities.Concrete
{
	public class Teklif : IEntity
    {
        public int Id { get; set; }
        public string AdSoyad { get; set; }
        public string FirmaAdi { get; set; }
        public string Telefon { get; set; }
        public string Eposta { get; set; }
        public string Konu { get; set; }
        public string Mesaj { get; set; }
        public string Tasarim { get; set; }
        public bool Durum { get; set; }
        public DateTime Ekleme { get; set; } = DateTime.Now;
    }
}
