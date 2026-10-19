using Kurumsal.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Kurumsal.WebUI.Models
{
    public class UrunKategoriViewModel
    {
        public UrunKategori UrunKategori { get; set; }
        public List<UrunKategori> UrunKategoriler { get; set; }
        public List<UrunKategori> UrunUstKategoriler { get; set; }
		public SelectList UstKategoriList { get; set; }
		[JsonIgnore]
        public IFormFile Dosya { get; set; }
    }
}
