using Kurumsal.Entities.Concrete;

namespace Kurumsal.DumanSafir.WebUI.Models
{
    public class SayfaViewModel
    {
        public IletisimAyar IletisimAyar { get; set; }
        public Slider Slider { get; set; }
        public Ftp Ftp { get; set; }
        public SiteAyar SiteAyar { get; set; }
        public List<Sayfa> Sayfalar { get; set; }
        public Sayfa Sayfa { get; set; }

    }
}
