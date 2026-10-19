using Kurumsal.Entities.Concrete;

namespace evonotel_com.Models
{
    public class FotoGaleriViewModel
    {
        public IletisimAyar IletisimAyar { get; set; }
        public FotoGaleri FotoGaleri { get; set; }
        public Ftp Ftp { get; set; }
        public SiteAyar SiteAyar { get; set; }
        public List<FotoGaleri> FotoGaleriler { get; set; }
        public List<Fotograf> Fotograflar { get; set; }
    }
}
