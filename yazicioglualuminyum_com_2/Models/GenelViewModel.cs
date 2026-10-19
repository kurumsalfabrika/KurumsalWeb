using Kurumsal.Entities.Concrete;

namespace yazicioglualuminyum_com_2.Models
{
    public class GenelViewModel
    {
        public SiteAyar SiteAyar { get; set; }
        public Ftp Ftp { get; set; }
        public Menu Menu { get; set; }
        public IletisimAyar Iletisim { get; set; }
        public UrunKategori UrunKategori { get; set; }
        public InsaatProje InsaatProje { get; set; }
        public IEnumerable<Menu> Menuler { get; set; }
        public IEnumerable<Slider> Sliderlar { get; set; }
        public IEnumerable<UrunKategori> UrunKategoriler { get; set; }
        public IEnumerable<Referans> Referanslar { get; set; }
        public IEnumerable<Sayfa> Sayfalar { get; set; }
        public IEnumerable<Oda> Odalar { get; set; }
        public IEnumerable<SosyalMedyaAdres> SosyalMedyaAdresler { get; set; }
        public IEnumerable<InsaatProje> InsaatProjeler{ get; set; }
        public Sayfa Sayfa { get; set; }
    }
}
