using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kurumsal.WebUI.Models
{
    public class RoleViewModel
    {
        [Required(ErrorMessage = "Ad alanı boş geçilemez!")]
        public string Name { get; set; }
    }
}
