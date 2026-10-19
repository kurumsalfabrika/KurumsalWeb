using Kurumsal.Entities.Concrete;

namespace Kurumsal.Eticaret.Models
{
    public class AnasayfaViewModel
    {
        public IletisimAyar IletisimAyar { get; set; }
        public Slider Slider { get; set; }
        public Ftp Ftp { get; set; }
        public SiteAyar SiteAyar { get; set; }
        public List<Slider> Sliderlar { get; set; }
        public List<Urun> VitrinUrunleri { get; set; }
    }

    public class UrunKategoriViewModel
    {
        public Ftp Ftp { get; set; }
        public SiteAyar SiteAyar { get; set; }
        public UrunKategori UrunKategori { get; set; }
        public List<UrunKategori> UrunKategoriler { get; set; }
        public List<Urun> Urunler { get; set; }
    }

    public class UrunViewModel
    {
        public Ftp Ftp { get; set; }
        public SiteAyar SiteAyar { get; set; }
        public Urun Urun { get; set; }
        public UrunKategori UrunKategori { get; set; }
        public List<Urun> Urunler { get; set; }
    }
}
