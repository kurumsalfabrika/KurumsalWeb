using Kurumsal.Core.Entities;
using System;

namespace Kurumsal.Entities.Concrete
{
	public class IletisimAyar : IEntity
    {
        public int Id { get; set; }
        public int Sira { get; set; } = 1;
        public string FirmaUnvani { get; set; }
        public string Telefon1 { get; set; }
        public string Telefon2 { get; set; }
        public string Telefon3 { get; set; }
        public string Telefon4 { get; set; }
        public string GSM { get; set; }
        public string Faks { get; set; }
        public string IletisimEposta { get; set; }
        public string SiparisEposta { get; set; }
        public string FirmaAdres { get; set; }
        public bool Varsayilan { get; set; } = false;
        public  string XKoordinat { get; set; }
        public  string YKoordinat { get; set; }
        public DateTime Ekleme { get; set; } = DateTime.Now;
    }
}
