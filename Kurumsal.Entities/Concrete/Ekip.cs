using Kurumsal.Core.Entities;
using System;

namespace Kurumsal.Entities.Concrete
{
    public class Ekip : IEntity
    {
        public int Id { get; set; }
        public int Sira { get; set; } = 0;
        public string Baslik { get; set; }
        public string Gorevi { get; set; }
        public string ProfilGorseli { get; set; }
        public bool DetayGoster { get; set; }
        public string KisaOzgecmis { get; set; }
        public string SEOUrl { get; set; }
        public string SEOAciklama { get; set; }
        public string SEOKelimeler { get; set; }
        public bool Durum { get; set; }
        public bool AnasayfadaGoster { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string Insagram { get; set; }
        public string Youtube { get; set; }
        public string Linkedin { get; set; }
        public DateTime Ekleme { get; set; } = DateTime.Now;
    }
}
