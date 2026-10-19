using Kurumsal.Entities.Concrete;

namespace kirilmazlar_com_tr.Models
{
    public class UrunViewModel
    {
        public IletisimAyar IletisimAyar { get; set; }
        public Ftp Ftp { get; set; }
        public Urun Urun { get; set; }
        public Marka Marka { get; set; }
        public UrunKategori UrunKategori { get; set; }
        public SiteAyar SiteAyar { get; set; }
        public List<Urun> Urunler { get; set; }
        public List<UrunKategori> UrunKategorileri{ get; set; }
        public List<Marka> Markalar{ get; set; }
       
    }
}
