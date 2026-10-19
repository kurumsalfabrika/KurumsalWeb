using Kurumsal.Entities.Concrete;

namespace Kurumsal.Sodemcanta2.WebUI.Models
{
    public class UrunViewModel
    {
        public IletisimAyar IletisimAyar { get; set; }
        public Urun Urun { get; set; }
        public UrunKategori UrunKategori { get; set; }
        public Ftp Ftp { get; set; }
        public SiteAyar SiteAyar { get; set; }
        public List<Urun> Urunler { get; set; }
        public List<UrunKategori> UrunKategoriler { get; set; }
    }
}
