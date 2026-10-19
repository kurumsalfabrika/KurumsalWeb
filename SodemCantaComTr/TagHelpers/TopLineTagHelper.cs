using Kurumsal.Business.Abstract;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SodemCantaComTr.TagHelpers
{
    [HtmlTargetElement("top-line-tag")]
    public class TopLineTagHelper : TagHelper
    {
        private readonly IMenuService _menuService;
        private readonly IFtpService _ftpService;
        private readonly ISiteAyarService _siteAyarService;
        private readonly IIletisimAyarService _iletisimAyarService;
        private readonly ISosyalMedyaAdresService _sosyalMedyaAdresService;

        public TopLineTagHelper(IMenuService menuService, IFtpService ftpService, ISiteAyarService siteAyarService, IIletisimAyarService iletisimAyarService, ISosyalMedyaAdresService sosyalMedyaAdresService)
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
                        <div id=""top_line"" style=""background-color:#ffd700 !important;"">
	                        <div class=""container"">
		                        <div class=""row"">
			                        <div class=""col-md-3 col-12 text-center"">
				                        <span id=""tag_line"">""{siteAyar.Slogan}""</span>
			                        </div>
			                        <div class=""col-md-9 col-12"">
				                        <ul id=""top_links"">
					                        <li><a href=""tel://{iletisim.Telefon1}"" id=""phone_top"">{iletisim.Telefon1}</a></li>
                                            <li><a href=""mailto://{iletisim.IletisimEposta}"" id=""mail_top"">{iletisim.IletisimEposta}</a></li>";


                                        foreach (var sosyalmedya in sosyalMedyaAdreslerim.OrderBy(x => x.Sira))
                                        {
                                            content += $@"<li class=""desktop-video""><a href=""{sosyalmedya.Url}"" target=""_blank"" title=""{sosyalmedya.Ad}""><i class=""{sosyalmedya.Ikon}""></i></a></li>";

                                        }

                                        content += $@" </ul>
			                        </div>
		                        </div>
	                        </div>
                        </div>";
            }
            catch (Exception)
            {
            }
            output.Content.SetHtmlContent(content);
        }
    }
}
