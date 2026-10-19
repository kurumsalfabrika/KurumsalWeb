using Kurumsal.Entities.Concrete;

namespace Kurumsal.Site.Models
{
    public class HomeViewModel
    {
        public List<Slider> Sliderler { get; set; }
        public List<Hizmet> Hizmetler { get; set; }
        public Hizmet Hizmet { get; set; }
        public List<Referans> Referanslar { get; set; }
        public Referans Referans { get; set; }
        public List<Portfolyo> Portfolyolar { get; set; }
        public Portfolyo Portfolyo { get; set; }
        public Ftp Ftp { get; set; }
        public SiteAyar SiteAyar { get; set; }
    }
}
