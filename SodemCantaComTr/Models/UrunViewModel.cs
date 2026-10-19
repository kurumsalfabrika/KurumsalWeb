using Kurumsal.Entities.Concrete;

namespace SodemCantaComTr.Models
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
        public List<UrunKategori> ListelenecekKategoriler { get; set; }
        public List<Fotograf> Fotograflar { get; set; }
    }
}
