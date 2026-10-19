using Kurumsal.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Kurumsal.WebUI.Models
{
    public class InsaatProjeViewModel
    {
        public InsaatProje InsaatProje { get; set; }
        public Ftp Ftp { get; set; }
        public SiteAyar SiteAyar { get; set; }
        public List<InsaatProje> InsaatProjeler { get; set; }
        public List<Fotograf> IcMekanGorselleri { get; set; }
        public List<Fotograf> DisMekanGorselleri { get; set; }
        public List<Fotograf> KrokiGorselleri { get; set; }
        public List<SelectListItem> ProjeDurumlari { get; set; }
        [JsonIgnore]
        public IFormFile Dosya { get; set; }
    }
}
