using Kurumsal.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Kurumsal.WebUI.Models
{
	public class BlogViewModel
    {
        public Blog Blog { get; set; }
        public List<Blog> Bloglar { get; set; }
        [JsonIgnore]
        public IFormFile Dosya { get; set; }
    }    
    
    

}
