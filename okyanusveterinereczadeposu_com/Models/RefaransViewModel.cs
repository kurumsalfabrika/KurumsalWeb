using Kurumsal.Entities.Concrete;

namespace okyanusveterinereczadeposu_com.Models
{
    public class RefaransViewModel
    {
        public Ftp Ftp { get; set; }
        public SiteAyar SiteAyar { get; set; }
        public List<Referans> Referanslar { get; set; }
        public Referans Referans { get; set; }
    }
}
