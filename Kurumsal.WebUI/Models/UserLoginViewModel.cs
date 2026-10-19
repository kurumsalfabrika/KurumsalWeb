using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kurumsal.WebUI.Models
{
    public class UserLoginViewModel
    {
        [Required(ErrorMessage ="Kullanıcı adı boş geçilemez!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Şifre boş geçilemez!")]
        public string Password { get; set; }
        public bool RememberMe { get; set; } = false;
    }
}
