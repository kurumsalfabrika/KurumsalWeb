using Kurumsal.Core.Entities;
using System;

namespace Kurumsal.Entities.Concrete
{
    public class GenelAyar : IEntity
    {
        public int Id { get; set; }
        public string Logo { get; set; }
        public string MailHeaderLogo { get; set; }
        public string Favicon { get; set; }
        public string GenelRenk1 { get; set; }
        public string GenelRenk2 { get; set; }
        public string GenelRenk3 { get; set; }
        public string SiteURL { get; set; }
        public string SiteTitle { get; set; }
        public int? ParaBirimi { get; set; }
        public string YonetimLink { get; set; }
        public string SEOKelimeler { get; set; }
        public string SEOAciklama { get; set; }
        public string CopyrightMetin { get; set; }
        public DateTime Ekleme { get; set; } = DateTime.Now;
    }
}
