using Kurumsal.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Kurumsal.WebUI.Models
{
    public class SSSViewModel
    {
        public SSS SSS { get; set; }
        public SSSKategori SSSKategori { get; set; }
        public List<SSS> SSSler { get; set; }
        public List<SSSKategori> SSSKategorileri { get; set; }
        public IEnumerable<SelectListItem> SSSKategoriList { get; set; }
        [JsonIgnore]
        public IFormFile Dosya { get; set; }
    }
}
