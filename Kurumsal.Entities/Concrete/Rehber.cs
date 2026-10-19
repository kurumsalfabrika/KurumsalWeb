using Kurumsal.Core.Entities;
using System;

namespace Kurumsal.Entities.Concrete
{
    public class Rehber : IEntity
    {
        public int Id { get; set; }
        public string AdSoyad { get; set; }
        public string Telefon { get; set; }
        public string Eposta { get; set; }
        public string PostaAdresi { get; set; }
        public string Aciklama { get; set; }
        public bool Durum { get; set; }
        public DateTime Ekleme { get; set; } = DateTime.Now;
    } 
}
