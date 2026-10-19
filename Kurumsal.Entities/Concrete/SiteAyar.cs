using Kurumsal.Core.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kurumsal.Entities.Concrete
{
    public class SiteAyar : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string HeaderLogoAcikRenk { get; set; }
        public string HeaderLogoKoyuRenk { get; set; }
        public string HeaderLogoURL { get; set; }
        public string HeaderLogoAciklama { get; set; }

        public string HolderLogo { get; set; }
        public string HolderLogoURL { get; set; }
        public string HolderLogoAciklama { get; set; }

        public string FooterLogo { get; set; }
        public string FooterLogoURL { get; set; }
        public string FooterLogoAciklama { get; set; }

        public string Slogan { get; set; }
        public string Konum { get; set; }
        public string SiteAdi { get; set; }
        public string KisaHakkindaYazisi { get; set; }
        public string SiteURL { get; set; }

        public string HeaderCSSAlani { get; set; }
        public string BodyHTMLAlani { get; set; }
        public string FooterCSSAlani { get; set; }

        public string Favicon { get; set; }
    } 
}
