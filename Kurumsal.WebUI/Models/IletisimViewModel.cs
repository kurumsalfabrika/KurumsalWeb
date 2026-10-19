using Kurumsal.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Kurumsal.WebUI.Models
{
	public class IletisimViewModel
    {
        public Iletisim Iletisim { get; set; }
        public List<Iletisim> Iletisimler { get; set; }
        [JsonIgnore]
        public IFormFile Dosya { get; set; }
    }    
    
    

}
