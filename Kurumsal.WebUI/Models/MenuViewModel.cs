using Kurumsal.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Kurumsal.WebUI.Models
{
    public class MenuViewModel
    {
        public Menu Menu { get; set; }
        public List<Menu> Menuler { get; set; }
        [JsonIgnore]
        public IFormFile Dosya { get; set; }
    }
}
