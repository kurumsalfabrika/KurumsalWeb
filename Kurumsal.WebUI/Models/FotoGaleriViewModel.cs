using Kurumsal.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Kurumsal.WebUI.Models
{
    public class FotoGaleriViewModel
    {
        public FotoGaleri FotoGaleri { get; set; }
        public List<FotoGaleri> FotoGaleriler { get; set; }
        public IEnumerable<SelectListItem> FotoGaleriKategoriList { get; set; }
        [JsonIgnore]
        public IFormFile Dosya { get; set; }
    }
}
