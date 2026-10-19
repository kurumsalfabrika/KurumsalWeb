using Kurumsal.Business.Abstract;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.SqlServer.Server;
using System;

namespace Kurumsal.Otel.WebUI.TagHelpers
{
    [HtmlTargetElement("header-tag")]
    public class HeaderTagHelper : TagHelper
    {
        private readonly IMenuService _menuService;
        private readonly IFtpService _ftpService;
        private readonly ISiteAyarService _siteAyarService;
        private readonly IIletisimAyarService _iletisimAyarService;

        public HeaderTagHelper(IMenuService menuService, IFtpService ftpService, ISiteAyarService siteAyarService, IIletisimAyarService iletisimAyarService)
        {
            _menuService = menuService;
            _ftpService = ftpService;
            _siteAyarService = siteAyarService;
            _iletisimAyarService = iletisimAyarService;
        }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            var menuler = await _menuService.GetAllAsync();
            var anaMenuler = menuler.Where(m => m.AnaMenuId == 0).ToList();

            var ftpBilgileri = await _ftpService.GetByIdAsync(1);
            var siteAyar = await _siteAyarService.GetByIdAsync(1);
            var iletisim = await _iletisimAyarService.GetByAsync(x=>x.Varsayilan==true);


            output.TagName = ""; // Eğer hiçbir wrapper tag kullanmak istemiyorsanız bu doğru, aksi halde div gibi bir tag kullanabilirsiniz.
            output.Attributes.SetAttribute("", ""); // Boş attribute kullanımı gereksizdir.
            var content = "";
            try
            {
                content = $@"<header class=""main_header_area headerstyle-2"">
        <div class=""header-content"">
            <div class=""container"">
                <div class=""links links-left"">
                    <ul>
                        <li><a href=""#""><i class=""fa fa-envelope"" aria-hidden=""true""></i> {iletisim.IletisimEposta}</a></li>
                        <li><a href=""#""><i class=""fa fa-phone"" aria-hidden=""true""></i> {iletisim.Telefon1}</a></li>

                    </ul>
                </div>
                <div class=""links links-right pull-right"">
                    <ul>
                        <li><a href=""#"" data-toggle=""modal"" data-target=""#login""><i class=""fa fa-user"" aria-hidden=""true""></i> Login</a></li>
                        <li><a href=""#"" data-toggle=""modal"" data-target=""#register""><i class=""fa fa-pen"" aria-hidden=""true""></i> Register</a></li>
                        <li>
                            <ul class=""social-links"">
                                <li><a href=""#""><i class=""fab fa-facebook"" aria-hidden=""true""></i></a></li>
                                <li><a href=""#""><i class=""fab fa-twitter"" aria-hidden=""true""></i></a></li>
                                <li><a href=""#""><i class=""fab fa-instagram"" aria-hidden=""true""></i></a></li>
                                <li><a href=""#""><i class=""fab fa-google-plus"" aria-hidden=""true""></i></a></li>
                            </ul>
                        </li>
                    </ul>
                </div>
            </div>
        </div>
        <!-- Navigation Bar -->
        <div class=""header_menu affix-top"">
            <nav class=""navbar navbar-default"">
                <div class=""container"">
                    <!-- Brand and toggle get grouped for better mobile display -->
                    <div class=""navbar-header"">
                        <a class=""navbar-brand"" href=""index.html"">
                            <img alt=""logo1"" src=""{ftpBilgileri.DosyaAdresOnEki}{siteAyar.HeaderLogoKoyuRenk}"" style=""max-width:200px;"" class=""logo-black img-fluid"">
                        </a>
                        <a class=""navbar-brand"" href=""index.html"">
                            <img alt=""logo1"" src=""{ftpBilgileri.DosyaAdresOnEki}{siteAyar.HeaderLogoAcikRenk}""  style=""max-width:200px;"" class=""logo-white img-fluid"">
                        </a>
                    </div>
                ";
            }
            catch (Exception)
            {


            }
            content += $@"    <div class=""collapse navbar-collapse"" id=""bs-example-navbar-collapse-1"">";
            content += $@"    <ul class=""nav navbar-nav"" id=""responsive-menu"">";

            foreach (var menu in anaMenuler)
            {
                var altMenuler = menuler.Where(m => m.AnaMenuId == menu.Id).ToList();

                if (altMenuler.Count == 0)
                {

                    content += $@"<li><a href={menu.BaglantiAdresi}>{menu.MenuAdi}</a></li>";
                }
                else
                {
                    content += $@"<li class='dropdown submenu'> <a href=""{menu.BaglantiAdresi}"" class=""dropdown-toggle"" data-toggle=""dropdown"" role=""button"" aria-haspopup=""true"" aria-expanded=""false"">{menu.MenuAdi}<i class=""fa fa-angle-down"" aria-hidden=""true""></i></a>";
                }

                if (altMenuler.Count > 0)
                {
                    content += $@"<ul class=""dropdown-menu"">";
                    foreach (var item in altMenuler)
                    {
                        content += $"<li><a href=\"{item.BaglantiAdresi}\">{item.MenuAdi}</a></li>";
                    }
                    content += "</ul>";
                }
                content += "</li>";
            }

                content += $@"</ul>

                    </div >
                </div>
                <div id=""slicknav-mobile""></div>
            </nav>
        </div>
    </header>";

            output.Content.SetHtmlContent(content);
        }
    }
}
