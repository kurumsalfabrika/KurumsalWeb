using Kurumsal.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Kurumsal.WebUI.Models
{
	public class TeklifViewModel
	{
        public Teklif Teklif { get; set; }
        public List<Teklif> Teklifler { get; set; }
        [JsonIgnore]
        public IFormFile Dosya { get; set; }
    }
}
