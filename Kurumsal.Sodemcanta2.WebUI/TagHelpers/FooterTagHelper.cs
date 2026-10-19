using Kurumsal.Business.Abstract;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Kurumsal.Sodemcanta2.WebUI.TagHelpers
{
	[HtmlTargetElement("footer-tag")]
	public class FooterTagHelper : TagHelper
	{
		private readonly IMenuService _menuService;
		private readonly IFtpService _ftpService;
		private readonly ISiteAyarService _siteAyarService;
		private readonly IIletisimAyarService _iletisimAyarService;
		private readonly ISosyalMedyaAdresService _sosyalMedyaAdresService;

		public FooterTagHelper(IMenuService menuService, IFtpService ftpService, ISiteAyarService siteAyarService, IIletisimAyarService iletisimAyarService, ISosyalMedyaAdresService sosyalMedyaAdresService)
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

			var footerMenuler = menuler.Where(m => m.AnaMenuId == 0 && m.MenuYeriId == 3).ToList();

			var ftpBilgileri = await _ftpService.GetByIdAsync(1);
			var siteAyar = await _siteAyarService.GetByIdAsync(1);
			var iletisim = await _iletisimAyarService.GetByAsync(x => x.Varsayilan == true);


			output.TagName = ""; // Eğer hiçbir wrapper tag kullanmak istemiyorsanız bu doğru, aksi halde div gibi bir tag kullanabilirsiniz.
			output.Attributes.SetAttribute("", ""); // Boş attribute kullanımı gereksizdir.
			var content = "";
			try
			{
				content = $@"



	<footer>
		<div class=""container"">
			<div class=""row justify-content-between"">
				<div class=""col-lg-4 col-md-8"">
					<img src=""{ftpBilgileri.DosyaAdresOnEki}{siteAyar.FooterLogo}"" width=""190""  alt=""{siteAyar.Favicon}"" id=""logo_footer"">
					<p>{siteAyar.KisaHakkindaYazisi}</p>
				</div>
				<div class=""col-lg-3 col-md-4"">
					<h3 style=""color:#fdb71a;"">Menüler</h3>
					<ul>";

				foreach (var item in footerMenuler)
				{
					content += $@"

						<li><a href=""{item.BaglantiAdresi}"" title=""{item.MenuAdi}"">{item.MenuAdi}</a></li>";
				}

				content += $@"</ul>
				</div>
				<div class=""col-lg-4 col-12"" id=""contact_bg"">
					<h3 style=""color:#fdb71a;"">İletişim</h3>
					<ul id=""contact_details_footer"">
						<li id=""address_footer"">{iletisim.FirmaAdres}</li>
						<li id=""phone_footer""><a href=""tel://{iletisim.Telefon1}"">{iletisim.Telefon1}</a> / <a href=""tel://{iletisim.Telefon2}"">{iletisim.Telefon2}</a></li>
						<li id=""email_footer""><a href=""#0"">{iletisim.IletisimEposta}</a></li>
				
					</ul>
				</div>
			</div><!-- End row -->
			<div id=""social_footer"">
				<ul>";
				foreach (var sosyalmedya in sosyalMedyaAdreslerim.OrderBy(x=>x.Sira))
				{
					content += $@"<li><a href=""{sosyalmedya.Url}"" target=""_blank"" title=""{sosyalmedya.Ad}""><i class=""{sosyalmedya.Ikon}""></i></a></li>";

				}




                content += $@"</ul>

<a href=""https://www.sodemcanta.com"" title=""Sodem Çanta""><img src=""https://www.sodemcanta.com.tr/Files/sodem.png"" style=""width:100px;"" /></a>
			</div>
		</div>
		<div id=""copy"">
			<div class=""container"">
				© {siteAyar.SiteAdi} {DateTime.Now.Year} - All rights reserved.
			</div>
		</div>
	</footer>";
			}
			catch (Exception)
			{


			}
			

			output.Content.SetHtmlContent(content);
		}
	}
}
