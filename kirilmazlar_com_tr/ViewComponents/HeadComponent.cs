using kirilmazlar_com_tr.Models;
using Kurumsal.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace kirilmazlar_com_tr.ViewComponents
{
    public class HeadComponent : ViewComponent
    {
        public readonly ISayfaService _sayfaService;
        public readonly ISiteAyarService _siteAyarService;
        public readonly IFtpService _ftpService;
        public readonly IIletisimAyarService _iletisimAyarService;
        public readonly IMenuService _menuService;
        public readonly ISosyalMedyaAdresService _sosyalMedyaAdresService;
        public HeadComponent(ISliderService sliderService, ISiteAyarService siteAyarService, IFtpService ftpService, IIletisimAyarService iletisimAyarService, ISayfaService sayfaService, ISosyalMedyaAdresService sosyalMedyaAdresService, IMenuService menuService)
        {
            _siteAyarService = siteAyarService;
            _ftpService = ftpService;
            _iletisimAyarService = iletisimAyarService;
            _sayfaService = sayfaService;
            _sosyalMedyaAdresService = sosyalMedyaAdresService;
            _menuService = menuService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = new AnasayfaViewModel();

            var menuler = await _menuService.GetAllAsync();
            var anaMenuler = menuler.Where(m => m.AnaMenuId == 0 && m.MenuYeriId == 1).ToList();
            var sosyalMedyaAdreslerim = await _sosyalMedyaAdresService.GetAllAsync();
            var footerMenuler = menuler.Where(m => m.AnaMenuId == 0 && m.MenuYeriId == 3).ToList();
            var ftpBilgileri = await _ftpService.GetByIdAsync(1);
            var siteAyar = await _siteAyarService.GetByIdAsync(1);
            var iletisim = await _iletisimAyarService.GetByAsync(x => x.Varsayilan == true);

            model.Menuler = menuler;
            model.AnaMenuler = anaMenuler;
            model.SosyalMedyaAdresler = sosyalMedyaAdreslerim;
            model.FooterMenuler = footerMenuler;
            model.Ftp = ftpBilgileri;
            model.SiteAyar = siteAyar;
            model.IletisimAyar = iletisim;

            return View(model);
        }
    }
}
