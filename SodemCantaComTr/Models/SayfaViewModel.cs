using Kurumsal.Entities.Concrete;

namespace SodemCantaComTr.Models
{
    public class SayfaViewModel
    {
        public IletisimAyar IletisimAyar { get; set; }
        public Sayfa Sayfa { get; set; }
        public Ftp Ftp { get; set; }
        public SiteAyar SiteAyar { get; set; }
        public List<Sayfa> Sayfalar { get; set; }
    }
}
