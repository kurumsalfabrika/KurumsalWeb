using Kurumsal.Business.Abstract;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Kurumsal.Eticaret.TagHelpers
{
    [HtmlTargetElement("header-mid-tag")]
    public class HeaderMidTagHelper : TagHelper
    {
        private readonly IMenuService _menuService;
        private readonly IUrunKategoriService _urunKategoriService;
        private readonly IFtpService _ftpService;
        private readonly ISiteAyarService _siteAyarService;
        private readonly IIletisimAyarService _iletisimAyarService;
        private readonly ISosyalMedyaAdresService _sosyalMedyaAdresService;

        public HeaderMidTagHelper(IMenuService menuService, IFtpService ftpService, ISiteAyarService siteAyarService, IIletisimAyarService iletisimAyarService, ISosyalMedyaAdresService sosyalMedyaAdresService, IUrunKategoriService urunKategoriService)
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
            var kategoriler = await _urunKategoriService.GetAllAsync();

            var topMenu = menuler.Where(m => m.AnaMenuId == 0 && m.MenuYeriId == 4).ToList();
   

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

        <div class=""header-mid"">
            <div class=""container"">
                <div class=""heade-mid-inner"">
                    <div class=""row align-items-center"">
                        <div class=""col-xl-3 col-lg-3 col-md-4 col-sm-4"">
                            <div class=""header__info"">
                                <div class=""logo"">
                                    <a href=""/anasayfa/anasayfa.html"" class=""logo-image""><img src=""{ftpBilgileri.DosyaAdresOnEki}{siteAyar.HeaderLogoAcikRenk}"" alt=""{siteAyar.SiteAdi}""></a>
                                </div>
                            </div>
                        </div>
                        <div class=""col-xl-5 col-lg-4 d-none d-lg-block"">
                            <div class=""header__search"">
                                <form action=""#"">
                                    <div class=""header__search-box"">
                                        <input class=""search-input"" type=""text"" placeholder=""Aranacak kelimeyi yazınız..."">
                                        <button class=""button"" type=""submit""><i class=""far fa-search""></i></button>
                                    </div>
                                    <div class=""header__search-cat"">
                                        <select><option>Tüm Kategoriler</option>

";
                foreach (var item in kategoriler)
                {
                    content += $@"
<option>{item.KategoriAdi}</option>";
						
                }
                                        
      content += $@"                                  </select>
                                    </div>
                                </form>
                            </div>
                        </div>
                        <div class=""col-xl-4 col-lg-5 col-md-8 col-sm-8"">
                            <div class=""header-action"">
                                <div class=""block-userlink"">
                                    <a class=""icon-link"" href=""my-account.html"">
                                    <i class=""flaticon-user""></i>
                                    <span class=""text"">
                                    <span class=""sub"">Giriş </span>
                                    Hesabım </span>
                                    </a>
                                </div>
                                <div class=""block-wishlist action"">
                                    <a class=""icon-link"" href=""wishlist.html"">
                                    <i class=""flaticon-heart""></i>
                                    <span class=""count"">0</span>
                                    <span class=""text"">
                                    <span class=""sub"">Favori</span>
                                    Listem </span>
                                    </a>
                                </div>
                                <div class=""block-cart action"">
                                    <a class=""icon-link"" href=""cart.html"">
                                    <i class=""flaticon-shopping-bag""></i>
                                    <span class=""count"">1</span>
                                    <span class=""text"">
                                    <span class=""sub"">Sepet:</span>
                                    $00.00 </span>
                                    </a>
                                    <div class=""cart"">
                                        <div class=""cart__mini"">
                                            <ul>
                                                <li>
                                                  <div class=""cart__title"">
                                                    <h4>Sepet</h4>
                                                    <span>(Sepette 1 ürün var)</span>
                                                  </div>
                                                </li>
                                                <li>
                                                  <div class=""cart__item d-flex justify-content-between align-items-center"">
                                                    <div class=""cart__inner d-flex"">
                                                      <div class=""cart__thumb"">
                                                        <a href=""product-details.html"">
                                                          <img src=""assets/img/cart/20.jpg"" alt="""">
                                                        </a>
                                                      </div>
                                                      <div class=""cart__details"">
                                                        <h6><a href=""product-details.html""> Samsung C49J89: £875, Debenhams Plus  </a></h6>
                                                        <div class=""cart__price"">
                                                          <span>$255.00</span>
                                                        </div>
                                                      </div>
                                                    </div>
                                                    <div class=""cart__del"">
                                                        <a href=""#""><i class=""fal fa-times""></i></a>
                                                    </div>
                                                  </div>
                                                </li>
                                                <li>
                                                  <div class=""cart__sub d-flex justify-content-between align-items-center"">
                                                    <h6>Subtotal</h6>
                                                    <span class=""cart__sub-total"">$255.00</span>
                                                  </div>
                                                </li>
                                                <li>
                                                    <a href=""cart.html"" class=""wc-cart mb-10"">View cart</a>
                                                    <a href=""checkout.html"" class=""wc-checkout"">Checkout</a>
                                                </li>
                                            </ul>
                                        </div>
                                    </div>
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
