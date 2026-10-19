using Kurumsal.Entities.Concrete;

namespace _3asosgb_com.Models
{
    public class HizmetViewModel
    {
        public IletisimAyar IletisimAyar { get; set; }
        public Hizmet Hizmet { get; set; }
        public Ftp Ftp { get; set; }
        public SiteAyar SiteAyar { get; set; }
        public List<Hizmet> Hizmetler { get; set; }
    }
}
