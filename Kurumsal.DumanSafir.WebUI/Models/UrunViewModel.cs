using Kurumsal.Entities.Concrete;

namespace Kurumsal.DumanSafir.WebUI.Models
{
    public class UrunViewModel
    {
        public IletisimAyar IletisimAyar { get; set; }
        public Urun Urun { get; set; }
        public Ftp Ftp { get; set; }
        public SiteAyar SiteAyar { get; set; }
        public List<Urun> Urunler { get; set; }
        public List<UrunKategori> UrunKategoriler { get; set; }
    }
}
