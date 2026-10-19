using Kurumsal.Entities.Concrete;

namespace okyanusveterinereczadeposu_com.Models
{
    public class UrunViewModel
    {
        public Ftp Ftp { get; set; }
        public SiteAyar SiteAyar { get; set; }
        public List<Urun> Urunler { get; set; }
        public List<UrunKategori> UrunKategoriler { get; set; }
        public Urun Urun { get; set; }
        public UrunKategori UrunKategori { get; set; }
    }
}
