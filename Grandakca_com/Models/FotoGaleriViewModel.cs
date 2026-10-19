using Kurumsal.Entities.Concrete;

namespace Grandakca_com.Models
{
    public class FotoGaleriViewModel
    {
        public Ftp Ftp { get; set; }
        public List<Fotograf> Fotograflar { get; set; }
        public List<FotoGaleri> FotoGaleriler { get; set; }
        public FotoGaleri FotoGaleri { get; set; }
        public Fotograf Fotograf { get; set; }

    }
}
