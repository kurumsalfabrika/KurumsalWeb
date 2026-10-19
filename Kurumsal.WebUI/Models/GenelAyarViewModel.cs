using Kurumsal.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Kurumsal.WebUI.Models
{
    public class GenelAyarViewModel
    {
        public GenelAyar GenelAyar { get; set; }
        public List<GenelAyar> GenelAyarlar { get; set; }
        [JsonIgnore]
        public IFormFile SiteUstuGorselDosya { get; set; }
        [JsonIgnore]
        public IFormFile HeaderLogoDosya { get; set; }
        [JsonIgnore]
        public IFormFile FooterLogoDosya { get; set; }
        [JsonIgnore]
        public IFormFile FaviconDosya { get; set; }
    }
}
