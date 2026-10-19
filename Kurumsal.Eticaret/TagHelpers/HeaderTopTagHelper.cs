using Kurumsal.Business.Abstract;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Kurumsal.Eticaret.TagHelpers
{
    [HtmlTargetElement("header-top-tag")]
    public class HeaderTopTagHelper : TagHelper
    {
        private readonly IMenuService _menuService;
        private readonly IFtpService _ftpService;
        private readonly ISiteAyarService _siteAyarService;
        private readonly IIletisimAyarService _iletisimAyarService;
        private readonly ISosyalMedyaAdresService _sosyalMedyaAdresService;

        public HeaderTopTagHelper(IMenuService menuService, IFtpService ftpService, ISiteAyarService siteAyarService, IIletisimAyarService iletisimAyarService, ISosyalMedyaAdresService sosyalMedyaAdresService)
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

            var topMenu = menuler.Where(m => m.AnaMenuId == 0 && m.MenuYeriId == 1).ToList();

            var anaMenuler = menuler.Where(m => m.AnaMenuId == 0 && m.MenuYeriId == 1).ToList();
            var sosyalMedyaAdreslerim = await _sosyalMedyaAdresService.GetAllAsync();

            var footerMenuler = menuler.Where(m => m.AnaMenuId == 0 && m.MenuYeriId == 3).ToList();

            var ftpBilgileri = await _ftpService.GetByIdAsync(1);
            var siteAyar = await _siteAyarService.GetByIdAsync(1);
            var iletisim = await _iletisimAyarService.GetByAsync(x => x.Varsayilan == true);


            output.TagName = ""; 
            output.Attributes.SetAttribute("", ""); 
            var content = "";
            try
            {
                content = $@"
      <div class=""header-top"">
            <div class=""container"">
                <div class=""header-inner"">
                    <div class=""row align-items-center"">
                        <div class=""col-xl-6 col-lg-7"">
                            <div class=""header-inner-start"">


                                <div class=""support d-none d-sm-block"">
                                    <p>Bize Ulaşın : <a href=""tel:{iletisim.Telefon1}""> {iletisim.Telefon1}</a></p>
                                </div>
                            </div>
                        </div>
                        <div class=""col-xl-6 col-lg-5 d-none d-lg-block"">
                            <div class=""header-inner-end text-md-end"">
                                <div class=""ovic-menu-wrapper"">
                                    <ul>";


                foreach (var item in topMenu)
                {
                    content += $@"

						<li><a href=""{item.BaglantiAdresi}"" title=""{item.MenuAdi}"">{item.MenuAdi}</a></li>";
                }

                content += $@"

                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

";
            }
            catch (Exception)
            {


            }


            output.Content.SetHtmlContent(content);
        }
    }
}
