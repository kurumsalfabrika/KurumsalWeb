using Kurumsal.Business.Abstract;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Kurumsal.Sodemcanta2.WebUI.TagHelpers
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
				content = $@"<header>
				<div id=""top_line"" style=""background-color:#ffd700 !important;"">
					<div class=""container"">
						<div class=""row"">
							<div class=""col-md-3 d-none d-md-block"">
								<span id=""tag_line"">""{siteAyar.Slogan}""</span>
							</div>

					<div class=""col-md-9"">
						<ul id=""top_links"">
							<li><a href=""tel://{iletisim.Telefon1}"" id=""mail_top"" style=""font-family:Arial;"">{iletisim.Telefon1}</a></li>
							<li><a href=""mailto://{iletisim.IletisimEposta}"" id=""mail_top"" style=""font-family:Arial;"">{iletisim.IletisimEposta}</a></li>";

                foreach (var sosyalmedya in sosyalMedyaAdreslerim.OrderBy(x=>x.Sira))
                {
                    content += $@"<li><a href=""{sosyalmedya.Url}"" target=""_blank"" title=""{sosyalmedya.Ad}""><i class=""{sosyalmedya.Ikon}""></i></a></li>";

                }
                content += $@"
							<li><a href=""{siteAyar.Konum}"" style=""font-size:14px; font-weight:700;"" target=""_blank""><i class=""fa-solid fa-location-dot""></i>  Konum</a></li>
						
						</ul>
					</div>
			
						</div><!-- End row -->
					</div><!-- End container-->
				</div><!-- End top line-->

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
							</header>";
            output.Content.SetHtmlContent(content);
		}
	}
}
