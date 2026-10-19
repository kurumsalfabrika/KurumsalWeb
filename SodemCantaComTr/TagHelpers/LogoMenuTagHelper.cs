using Kurumsal.Business.Abstract;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SodemCantaComTr.TagHelpers
{


    [HtmlTargetElement("logo-menu-tag")]
    public class LogoMenuTagHelper : TagHelper
    {
        private readonly IMenuService _menuService;
        private readonly IFtpService _ftpService;
        private readonly ISiteAyarService _siteAyarService;
        private readonly IIletisimAyarService _iletisimAyarService;
        private readonly ISosyalMedyaAdresService _sosyalMedyaAdresService;

        public LogoMenuTagHelper(IMenuService menuService, IFtpService ftpService, ISiteAyarService siteAyarService, IIletisimAyarService iletisimAyarService, ISosyalMedyaAdresService sosyalMedyaAdresService)
        {
            _menuService = menuService;
            _ftpService = ftpService;
            _siteAyarService = siteAyarService;
            _iletisimAyarService = iletisimAyarService;
            _sosyalMedyaAdresService = sosyalMedyaAdresService;
        }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            var menuler = await _menuService.GetAllAsync();
            var anaMenuler = menuler.Where(m => m.AnaMenuId == 0 && m.MenuYeriId == 1).ToList();
            var sosyalMedyaAdreslerim = await _sosyalMedyaAdresService.GetAllAsync();

            var ftpBilgileri = await _ftpService.GetByIdAsync(1);
            var siteAyar = await _siteAyarService.GetByIdAsync(1);
            var iletisim = await _iletisimAyarService.GetByAsync(x => x.Varsayilan == true);

            output.TagName = "";
            output.Attributes.SetAttribute("", "");
            var content = "";
            try
            {
                content = $@"
				

				<div class=""container"">
					<div class=""row d-flex align-items-center pt-3 pb-3"">
						<div class=""col-lg-3 col-6"">
							<div id=""logo"">
								<a href=""/anasayfa/anasayfa.html""><img src=""{ftpBilgileri.DosyaAdresOnEki}{siteAyar.HeaderLogoKoyuRenk}"" width=""190"" alt=""Sodem Çanta""></a>
							</div>
						</div>
						<nav class=""col-lg-9 col-6 position-relative"">
							<a class=""cmn-toggle-switch cmn-toggle-switch__htx open_close"" href=""javascript:void(0);""><span>Menu mobile</span></a>
							<div class=""main-menu"">
								<div id=""header_menu"">
									<img src=""{ftpBilgileri.DosyaAdresOnEki}{siteAyar.HeaderLogoKoyuRenk}"" width=""190""  alt=""Sodem Çanta"">
								</div>
								<a href=""#"" class=""open_close"" id=""close_in""><i class=""icon_close""></i></a>
								<ul>";
            }
            catch (Exception)
            {


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
            };

            content += "</ul>";
            content += $@"</div>
							</nav>
									</div>
								</div>
							";
            output.Content.SetHtmlContent(content);
        }
    }
}
