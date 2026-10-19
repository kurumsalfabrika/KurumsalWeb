using Kurumsal.Entities.Concrete;

namespace Kurumsal.DumanSafir.WebUI.Models
{
    public class SubeViewModel
    {
        public IletisimAyar IletisimAyar { get; set; }
        public Ftp Ftp { get; set; }
        public SiteAyar SiteAyar { get; set; }
        public List<Sube> Subeler { get; set; }
        public List<Fotograf> Fotograflar { get; set; }
        public Sube Sube { get; set; }

    }
}
