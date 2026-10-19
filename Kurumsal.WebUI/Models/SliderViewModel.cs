using Kurumsal.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Kurumsal.WebUI.Models
{
    public class SliderViewModel
    {
        public Slider Slider { get; set; }
        public List<Slider> Sliderlar { get; set; }
        [JsonIgnore]
        public IFormFile Dosya { get; set; }
        public IFormFile Dosya1 { get; set; }
        public IFormFile Dosya2 { get; set; }
    }
}
