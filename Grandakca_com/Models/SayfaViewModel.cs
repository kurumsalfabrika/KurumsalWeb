using Kurumsal.Entities.Concrete;

namespace Grandakca_com.Models
{
    public class SayfaViewModel
    {
        public IletisimAyar IletisimAyar { get; set; }
        public Ftp Ftp { get; set; }
        public SiteAyar SiteAyar { get; set; }
        public List<Slider> Sliderlar { get; set; }
        public List<Fotograf> Fotograflar { get; set; }
        public List<Sayfa> Sayfalar { get; set; }
        public List<Blog> Bloglar { get; set; }
        public Blog Blog { get; set; }
        public Sayfa Sayfa { get; set; }
        public List<OdaKategori> OdaKategoriler { get; set; }
        public List<Oda> Odalar { get; set; }
        public Oda Oda { get; set; }
        public List<Menu> Menuler { get; set; }
        public List<Menu> AnaMenuler { get; set; }
        public List<Menu> FooterMenuler { get; set; }
        public List<SosyalMedyaAdres> SosyalMedyaAdresler { get; set; }
    }
}
