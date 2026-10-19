using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Threading.Tasks;
using Kurumsal.Business.Abstract;
using Kurumsal.Entities.Concrete;

namespace Kurumsal.DumanSafir.WebUI.TagHelpers
{
    [HtmlTargetElement("header-tag")]
    public class HeaderTagHelper : TagHelper
    {
        private readonly IMenuService _menuService;
        private readonly IFtpService _ftpService;
        private readonly ISiteAyarService _siteAyarService;
        private readonly IIletisimAyarService _iletisimAyarService;
        private readonly ISosyalMedyaAdresService _sosyalMedyaAdresService;

        public HeaderTagHelper(IMenuService menuService, IFtpService ftpService, ISiteAyarService siteAyarService, IIletisimAyarService iletisimAyarService, ISosyalMedyaAdresService sosyalMedyaAdresService)
        {
            _menuService = menuService;
            _ftpService = ftpService;
            _siteAyarService = siteAyarService;
            _iletisimAyarService = iletisimAyarService;
            _sosyalMedyaAdresService = sosyalMedyaAdresService;
        }

        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext ViewContext { get; set; }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            var menuler = await _menuService.GetAllAsync();
            var anaMenuler = menuler.Where(m => m.AnaMenuId == 0 && m.MenuYeriId == 1).ToList();
            var sosyalMedyaAdreslerim = await _sosyalMedyaAdresService.GetAllAsync();

            var ftpBilgileri = await _ftpService.GetByIdAsync(1);
            var siteAyar = await _siteAyarService.GetByIdAsync(1);
            var iletisim = await _iletisimAyarService.GetByAsync(x => x.Varsayilan == true);

            var currency = ViewContext.HttpContext.Items["Currency"] as string ?? "949";

            output.TagName = ""; // Eğer hiçbir wrapper tag kullanmak istemiyorsanız bu doğru, aksi halde div gibi bir tag kullanabilirsiniz.
            output.Attributes.SetAttribute("", ""); // Boş attribute kullanımı gereksizdir.
            var content = "";
            try
            {
                content = $@"<header>
                <div id=""top_line"" style=""background-color:#ffd700 !important;"">
                    <div class=""container"">
                        <div class=""row"">
                            <div class=""col-md-3 d-none d-md-block"">
                                <span id=""tag_line"">""{siteAyar.Slogan}""</span>
                            </div>

                    <div class=""col-md-9"">
                        <ul id=""top_links"">
                            <li><a href=""tel://{iletisim.Telefon1}"" id=""phone_top"" style=""font-family:Arial;"">{iletisim.Telefon1}</a></li>";

                foreach (var sosyalmedya in sosyalMedyaAdreslerim)
                {
                    content += $@"<li><a href=""{sosyalmedya.Url}"" target=""_blank"" title=""{sosyalmedya.Ad}""><i class=""{sosyalmedya.Ikon}""></i></a></li>";
                }
                content += $@"
                            <li><a href=""{siteAyar.Konum}"" style=""font-size:14px; font-weight:700;"" target=""_blank""><i class=""bi bi-geo-alt""></i> Konum</a></li>

                        <li class=""currency-selector"">
                            <select id=""currency-select"">
                                <option value=""949""{(currency == "949" ? " selected" : "")}>TL</option>
                                <option value=""840""{(currency == "840" ? " selected" : "")}>USD</option>
                                <option value=""978""{(currency == "978" ? " selected" : "")}>EUR</option>
                            </select>
                        </li>
                        </ul>
                    </div>

                        
                        </div><!-- End row -->
                    </div><!-- End container-->
                </div><!-- End top line-->

                <div class=""container"">
                    <div class=""row d-flex align-items-center pt-3 pb-3"">
                        <div class=""col-lg-3 col-6"">
                            <div id=""logo"">
                                <a href=""/anasayfa/anasayfa.html""><img src=""{ftpBilgileri.DosyaAdresOnEki}{siteAyar.HeaderLogoKoyuRenk}"" width=""190"" height=""44"" alt=""Duman Safir""></a>
                            </div>
                        </div>
                        <nav class=""col-lg-9 col-6 position-relative"">
                            <a class=""cmn-toggle-switch cmn-toggle-switch__htx open_close"" href=""javascript:void(0);""><span>Menu mobile</span></a>
                            <div class=""main-menu"">
                                <div id=""header_menu"">
                                    <img src=""{ftpBilgileri.DosyaAdresOnEki}{siteAyar.HeaderLogoKoyuRenk}"" width=""190"" height=""44"" alt=""Duman Safir"">
                                </div>
                                <a href=""#"" class=""open_close"" id=""close_in""><i class=""icon_close""></i></a>
                                <ul>";
            }
            catch (Exception)
            {
                // Handle exception
            }

            foreach (var menu in anaMenuler)
            {
                var altMenuler = menuler.Where(m => m.AnaMenuId == menu.Id).ToList();

                if (altMenuler.Count == 0)
                {
                    content += $@"<li><a href={menu.BaglantiAdresi}>{menu.MenuAdi}</a></li>";
                }
                else
                {
                    content += $@"<li class=""submenu""><a href=""javascript:void(0);"" class=""show-submenu"">{menu.MenuAdi} <i class=""icon-down-open-mini""></i></a>";
                }

                if (altMenuler.Count > 0)
                {
                    content += $@"<ul>";
                    foreach (var item in altMenuler)
                    {
                        content += $"<li><a href=\"{item.BaglantiAdresi}\">{item.MenuAdi}</a></li>";
                    }
                    content += "</ul>";
                }
                content += "</li>";




            }
            content += $@"<li><a href=""https://www.reseliva.com/booknow/Saffire-Tower/?lang=tr"" class=""btn btn-danger"" style=""color:white;""  target=""_blank"">YURTİÇİ REZERVASYON</a></li>";
            content += "</ul>";
            content += $@"</div>
                            </nav>
                                    </div>
                                </div>
                            </header>";

            // JavaScript part
            content += @"
                <script>
                    document.getElementById('currency-select').addEventListener('change', function() {
                        var currency = this.value;
                        document.cookie = 'currency=' + currency + '; path=/; max-age=' + (60 * 60 * 24 * 30) + ';';
                        location.reload();
                    });

                    document.addEventListener('DOMContentLoaded', function() {
                        var match = document.cookie.match(new RegExp('(^| )currency=([^;]+)'));
                        if (match) {
                            document.getElementById('currency-select').value = match[2];
                        } else {
                            document.getElementById('currency-select').value = '949';
                        }
                    });
                </script>";

            output.Content.SetHtmlContent(content);
        }
    }
}
