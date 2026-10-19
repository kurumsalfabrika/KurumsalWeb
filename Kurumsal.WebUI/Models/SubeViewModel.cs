using Kurumsal.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Kurumsal.WebUI.Models
{
    public class SubeViewModel
    {
        public Sube Sube { get; set; }
        public Ftp Ftp { get; set; }
        public List<Sube> Subeler { get; set; }
        public IEnumerable<SelectListItem> FotoGaleriList { get; set; }
        [JsonIgnore]
        public IFormFile Dosya { get; set; }
    }
}
