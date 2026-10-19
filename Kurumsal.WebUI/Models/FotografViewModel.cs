using Kurumsal.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Kurumsal.WebUI.Models
{
    public class FotografViewModel
    {
        public Fotograf Fotograf { get; set; }
        public Ftp Ftp { get; set; }
        public SiteAyar SiteAyar { get; set; }
        public FotoGaleri FotoGaleri { get; set; }
        public List<FotoGaleri> FotoGaleriler { get; set; }
        public List<Fotograf> Fotograflar { get; set; }
        public IEnumerable<SelectListItem> HaberKategoriList { get; set; }
        [JsonIgnore]
        public IFormFile Dosya { get; set; }
    }
}
