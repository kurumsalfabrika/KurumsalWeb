using Kurumsal.Entities.Concrete;

namespace yazicioglualuminyum_com.Models
{
    public class GenelViewModel
    {
        public SiteAyar SiteAyar { get; set; }
        public Ftp Ftp { get; set; }
        public Menu Menu { get; set; }
        public IletisimAyar Iletisim { get; set; }
        public IEnumerable<Menu> Menuler { get; set; }
        public IEnumerable<Slider> Sliderlar { get; set; }
        public IEnumerable<Referans> Referanslar { get; set; }
        public IEnumerable<SosyalMedyaAdres> SosyalMedyaAdresler { get; set; }
        public IEnumerable<Sayfa> Sayfalar { get; set; }
        public IEnumerable<Oda> Odalar { get; set; }
        public Sayfa Sayfa { get; set; }
    }
}
