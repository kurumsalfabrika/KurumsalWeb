using Kurumsal.Entities.Concrete;

namespace kirilmazlar_com_tr.Models
{
    public class AnasayfaViewModel
    {
        public IletisimAyar IletisimAyar { get; set; }
        public Marka Marka { get; set; }
        public Slider Slider { get; set; }
        public Ftp Ftp { get; set; }
        public SiteAyar SiteAyar { get; set; }
        public List<Slider> Sliderlar { get; set; }
        public List<Fotograf> Fotograflar { get; set; }
        public List<Sayfa> Sayfalar { get; set; }
        public List<OdaKategori> OdaKategoriler { get; set; }
        public List<Referans> Referanslar { get; set; }
        public List<Menu> Menuler { get; set; }
        public List<Menu> AnaMenuler { get; set; }
        public List<Menu> FooterMenuler { get; set; }
        public List<SosyalMedyaAdres> SosyalMedyaAdresler { get; set; }
        public List<Marka> Markalar { get; set; }
   }

  
}
