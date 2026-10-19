using Kurumsal.Entities.Concrete;

namespace Kurumsal.DumanSafir.WebUI.Models
{
    public class AnasayfaViewModel
    {
        public IletisimAyar IletisimAyar { get; set; }
        public Slider Slider { get; set; }
        public Ftp Ftp { get; set; }
        public SiteAyar SiteAyar { get; set; }
        public List<Slider> Sliderlar { get; set; }
        public List<OdaKategori> OdaKategoriler { get; set; }
        public List<Haber> Haberler { get; set; }
        public List<Oda> Odalar { get; set; }
        public List<Yorum> Yorumlar { get; set; }

    }
}
