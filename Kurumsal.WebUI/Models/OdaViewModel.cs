using Kurumsal.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Kurumsal.WebUI.Models
{
    public class OdaViewModel
    {
        public Ftp Ftp { get; set; }
        public Oda Oda { get; set; }
        public OdaKategori OdaKategori { get; set; }
        public List<Oda> Odalar { get; set; }
        public List<OdaKategori> OdaKategorileri { get; set; }
        public List<FotoGaleri> FotoGaleriler { get; set; }
        public IEnumerable<SelectListItem> OdaKategoriList { get; set; }
        public IEnumerable<SelectListItem> FotoGaleriList { get; set; }
        [JsonIgnore]
        public IFormFile Dosya { get; set; }
    }
}
