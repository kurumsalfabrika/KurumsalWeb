using Kurumsal.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Kurumsal.WebUI.Models
{
    public class HaberViewModel
    {
        public Haber Haber { get; set; }
        public HaberKategori HaberKategori { get; set; }
        public List<Haber> Haberler { get; set; }
        public List<HaberKategori> HaberKategorileri { get; set; }
        public IEnumerable<SelectListItem> HaberKategoriList { get; set; }
        [JsonIgnore]
        public IFormFile Dosya { get; set; }
    }
}
