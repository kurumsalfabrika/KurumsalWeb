using Kurumsal.Business.Abstract;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace carita_com_tr.TagHelpers
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
                content = $@"
                <div class=""header homepagemenu"">
                    <div class="""">
                        <div class=""logo"">
                            <a href=""/anasayfa/giris.html""><img src=""{ftpBilgileri.DosyaAdresOnEki}{siteAyar.HeaderLogoAcikRenk}"" /></a>
                        </div>
                        <div class=""menu"">
                            <ul>
                ";


                foreach (var menu in anaMenuler)
                {
                    var altMenuler = menuler.Where(m => m.AnaMenuId == menu.Id).ToList();

                    if (altMenuler.Count == 0)
                    {

                        content += $@"<li ><a href={menu.BaglantiAdresi}>{menu.MenuAdi}</a></li>";
                    }
                    else
                    {
                        //content += $@"<li><a href=""javascript:void(0);"" >{menu.MenuAdi} </a>";
                    }

                    if (altMenuler.Count > 0)
                    {
                        //content += $@"<ul >";
                        //foreach (var item in altMenuler)
                        //{
                        //    content += $"<li ><a href=\"{item.BaglantiAdresi}\">{item.MenuAdi}</a></li>";
                        //}
                        //content += "</ul>";
                    }
                    //content += "</li>";
                };


                content += $@"

                </ul>
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
