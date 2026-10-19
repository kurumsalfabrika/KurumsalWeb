using Kurumsal.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Kurumsal.WebUI.Models
{
    public class FirmaViewModel
    {
     
            public IletisimAyar IletisimAyar { get; set; }
            public Slider Slider { get; set; }
            public Ftp Ftp { get; set; }
            public SiteAyar SiteAyar { get; set; }
            public List<Sayfa> Sayfalar { get; set; }
            public List<Firma> Firmalar { get; set; }
            public Firma Firma { get; set; }

   
        [JsonIgnore]
        public IFormFile Dosya { get; set; }
    }    
    
    

}
