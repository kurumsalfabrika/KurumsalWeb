using Kurumsal.Core.Entities;
using System;

namespace Kurumsal.Entities.Concrete
{
	public class Iletisim : IEntity
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }
        public string Eposta { get; set; }
        public string Konu { get; set; }
        public string Mesaj { get; set; }
        public bool Okundu { get; set; } = false;
        public DateTime? OkunmaTarihi { get; set; }
        public DateTime Ekleme { get; set; } = DateTime.Now;
    }
}
