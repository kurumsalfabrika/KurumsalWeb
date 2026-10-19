using Kurumsal.Business.Abstract;
using Kurumsal.Core.Functions;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Kurumsal.Eticaret.TagHelpers
{
 
    [HtmlTargetElement("header-bottom-tag")]
    public class HeaderBottomTagHelper : TagHelper
    {
        private readonly IMenuService _menuService;
        private readonly IFtpService _ftpService;
        private readonly ISiteAyarService _siteAyarService;
        private readonly IIletisimAyarService _iletisimAyarService;
        private readonly ISosyalMedyaAdresService _sosyalMedyaAdresService;
        private readonly IUrunKategoriService _urunKategoriService;

        public HeaderBottomTagHelper(IMenuService menuService, IFtpService ftpService, ISiteAyarService siteAyarService, IIletisimAyarService iletisimAyarService, ISosyalMedyaAdresService sosyalMedyaAdresService, IUrunKategoriService urunKategoriService)
        {
            _menuService = menuService;
            _ftpService = ftpService;
            _siteAyarService = siteAyarService;
            _iletisimAyarService = iletisimAyarService;
            _sosyalMedyaAdresService = sosyalMedyaAdresService;
            _urunKategoriService = urunKategoriService;
        }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            var menuler = await _menuService.GetAllAsync();
            var urunKategori = await _urunKategoriService.GetAllAsync();

            var topMenu = menuler.Where(m => m.AnaMenuId == 0 && m.MenuYeriId == 2).ToList();

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





        <div class=""header__bottom"">
            <div class=""container"">
                <div class=""row g-0 align-items-center"">
                    <div class=""col-lg-3"">                        
                        <div class=""cat__menu-wrapper side-border d-none d-lg-block"">
                            <div class=""cat-toggle"">
                                <button type=""button"" class=""cat-toggle-btn cat-toggle-btn-1""><i class=""fal fa-bars""></i> Kategoriler</button>
                                <div class=""cat__menu"">
                                    <nav id=""mobile-menu"" style=""display: block;"">
                                        <ul>";

                foreach (var item in urunKategori.Where(x=>x.UstKategoriId==null))
                {

                    var altKategori = urunKategori.Where(x => x.UstKategoriId == item.Id);

                    int altSayi = altKategori.Count();
                    //@Url.Content("~/urun/" + SeoUrlGenerator.GenerateSlug(item.VitrinUrunBaslik) + "-" + item.Id + ".html")
                    if (altSayi==0)
                    {
                        content += $@"  <li><a href=""{siteAyar.SiteURL}/kategori/{SeoUrlGenerator.GenerateSlug(item.KategoriAdi)}-{item.Id}.html"">{item.KategoriAdi}</a></li>";
                    }
                    else
                    {
                        content += $@"  <li>
                                                <a href=""{siteAyar.SiteURL}/kategori/{SeoUrlGenerator.GenerateSlug(item.KategoriAdi)}-{item.Id}.html"">{item.KategoriAdi} <i class=""far fa-angle-down""></i></a>
                                                <ul class=""submenu"">";
                        foreach (var altItem in altKategori)
                        {
                            content += $@"<li><a href=""{siteAyar.SiteURL}/kategori/{SeoUrlGenerator.GenerateSlug(altItem.KategoriAdi)}-{altItem.Id}.html"">{altItem.KategoriAdi}</a></li>";
                        }
                        content += $@"
                                                </ul>
                                            </li> ";
                    }



                }

content+=@$"
                                           
                                        </ul>
                                    </nav>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""col-lg-6 col-md-6 col-3"">
                      <div class=""header__bottom-left d-flex d-xl-block align-items-center"">
                        <div class=""side-menu d-lg-none mr-20"">
                          <button type=""button"" class=""side-menu-btn offcanvas-toggle-btn""><i class=""fas fa-bars""></i></button>
                        </div>
                        <div class=""main-menu d-none d-lg-block"">
                            <nav>
                                <ul>";
                foreach (var item in topMenu)
                {
                    content += $@"

						<li><a href=""{item.BaglantiAdresi}"" title=""{item.MenuAdi}"">{item.MenuAdi}</a></li>";
                }
                              
                        content+=$@"</ul>
                            </nav>
                        </div>
                      </div>
                    </div>
                    <div class=""col-lg-3 col-md-6 col-9"">
                        <div class=""shopeing-text text-sm-end"">
                            <p>{siteAyar.Slogan}</p>
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