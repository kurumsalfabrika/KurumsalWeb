using Kurumsal.Entities.Concrete;

namespace Grandakca_com.Models
{
    public class OdaViewModel
    {
        public IletisimAyar IletisimAyar { get; set; }
        public Ftp Ftp { get; set; }
        public SiteAyar SiteAyar { get; set; }
        public List<Fotograf> Fotograflar { get; set; }
        public List<Sayfa> Sayfalar { get; set; }
        public List<OdaKategori> OdaKategoriler { get; set; }
        public List<Oda> Odalar { get; set; }
        public Oda Oda { get; set; }
    }
}
