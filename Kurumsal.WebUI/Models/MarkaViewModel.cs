using Kurumsal.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Kurumsal.WebUI.Models
{
    public class MarkaViewModel
    {
        public Marka Marka { get; set; }
        public List<Marka> Markalar { get; set; }
        public IEnumerable<SelectListItem> HaberKategoriList { get; set; }
        [JsonIgnore]
        public IFormFile Dosya { get; set; }
    }
}
