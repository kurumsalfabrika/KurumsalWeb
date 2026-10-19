using Kurumsal.Entities.Concrete;

namespace Kurumsal.DumanSafir.WebUI.Models
{
    public class FotoGaleriViewModel
    {
        public IletisimAyar IletisimAyar { get; set; }
        public Slider Slider { get; set; }
        public Ftp Ftp { get; set; }
        public SiteAyar SiteAyar { get; set; }
        public List<FotoGaleri> FotoGaleriler { get; set; }
        public FotoGaleri FotoGaleri { get; set; }
        public List<Fotograf> Fotograflar { get; set; }
        public Fotograf Fotograf { get; set; }

    }
}
