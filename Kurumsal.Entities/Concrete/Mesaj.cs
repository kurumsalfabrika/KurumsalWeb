using Kurumsal.Core.Entities;
using System;

namespace Kurumsal.Entities.Concrete
{
    public class Mesaj : IEntity
    {
        public int Id { get; set; }
        public string Konu { get; set; }
        public string AdSoyad { get; set; }
        public string FirmaAdi { get; set; }
        public string Eposta { get; set; }
        public string Telefon { get; set; }
        public string Icerik { get; set; }
        public bool Durum { get; set; }
        public string GonderenIpAdresi { get; set; }
        public DateTime GelisTarihi { get; set; } = DateTime.Now;
        public DateTime OkunmaTarihi { get; set; } = DateTime.Now;
    }
}
