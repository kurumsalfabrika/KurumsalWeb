using Kurumsal.Business.Abstract;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace Kurumsal.Site.TagHelpers
{
    [HtmlTargetElement("header-tag")]
    public class HeaderTagHelper : TagHelper
    {
        private readonly IMenuService _menuService;
        private readonly IFtpService _ftpService;
        private readonly ISiteAyarService _siteAyarService;

        public HeaderTagHelper(IMenuService menuService, IFtpService ftpService, ISiteAyarService siteAyarService)
        {
            _menuService = menuService;
            _ftpService = ftpService;
            _siteAyarService = siteAyarService;
        }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            var menuler = await _menuService.GetAllAsync();
            var anaMenuler = menuler.Where(m => m.AnaMenuId == 0).ToList();

            var ftpBilgileri = await _ftpService.GetByIdAsync(1);
            var siteAyar = await _siteAyarService.GetByIdAsync(1);


            output.TagName = ""; // Eğer hiçbir wrapper tag kullanmak istemiyorsanız bu doğru, aksi halde div gibi bir tag kullanabilirsiniz.
            output.Attributes.SetAttribute("", ""); // Boş attribute kullanımı gereksizdir.
            var content = "";
            try
            {
                content = $@"<header class='main-header'>
                                <a href='' class='logo-holder'>
                                    <img src='{ftpBilgileri.DosyaAdresOnEki}{siteAyar.HolderLogo}' alt='logo'>
                                </a>

                                <div class='nav-button' id='open-button'>
                                    <span class='menu-global menu-top'></span>
                                    <span class='menu-global menu-middle'></span>
                                    <span class='menu-global menu-bottom'></span>
                                </div>

                                <div class='show-share isShare'>
                                    <img src='images/share.png' alt='share'>
                                </div>
                            </header>
                            <div class='menu-wrap'>
                                <div class='menu-inner'>
                                    <a href='/' class='menu-logo'>
                                        <img src='{ftpBilgileri.DosyaAdresOnEki}{siteAyar.HeaderLogoAcikRenk}' alt=''>
                                    </a>
                                    <div class='hid-men-wrap alt'>
                                        <div id='hid-men'><ul>";
            }
            catch (Exception)
            {


            }


            foreach (var menu in anaMenuler)
            {
                var altMenuler = menuler.Where(m => m.AnaMenuId == menu.Id).ToList();

                if (altMenuler.Count == 0)
                {

                    content += $"<li><a href=\"{menu.BaglantiAdresi}\">{menu.MenuAdi}</a>";
                }
                else
                {
                    content += $"<li><a href=\"{menu.BaglantiAdresi}\">{menu.MenuAdi} &#9654; </a>";
                }

                if (altMenuler.Count > 0)
                {
                    content += "<ul>";
                    foreach (var item in altMenuler)
                    {
                        content += $"<li><a href=\"{item.BaglantiAdresi}\">{item.MenuAdi}</a></li>";
                    }
                    content += "</ul>";
                }
                content += "</li>";
            }

            content += $@"               </ul> </div>
                                        </div>
                                    </div>
                                    <div class='morph-shape' id='morph-shape' data-morph-open='M-7.312,0H15c0,0,66,113.339,66,399.5C81,664.006,15,800,15,800H-7.312V0z;M-7.312,0H100c0,0,0,113.839,0,400c0,264.506,0,400,0,400H-7.312V0z'>
                                        <svg xmlns='http://www.w3.org/2000/svg' width='100%' height='100%' viewBox='0 0 100 800' preserveAspectRatio='none'>
                                            <path d='M-7.312,0H0c0,0,0,113.839,0,400c0,264.506,0,400,0,400h-7.312V0z'/>
                                        </svg>
                                    </div>
                                </div>";

            output.Content.SetHtmlContent(content);
        }
    }
}
