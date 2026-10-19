using Kurumsal.Entities.Concrete;

namespace Kurumsal.Sodemcanta2.WebUI.Models
{
    public class ReferansViewModel
    {
        public IletisimAyar IletisimAyar { get; set; }
        public Referans Referans { get; set; }
        public Ftp Ftp { get; set; }
        public SiteAyar SiteAyar { get; set; }
        public List<Referans> Referanslar{ get; set; }
    }
}
