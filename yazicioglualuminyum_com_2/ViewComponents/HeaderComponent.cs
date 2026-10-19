using Kurumsal.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using yazicioglualuminyum_com_2.Models;

namespace yazicioglualuminyum_com_2.ViewComponents
{
    public class HeaderComponent : ViewComponent
    {
        public readonly ISiteAyarService _siteAyarService;
        public readonly IFtpService _ftpService;
        public readonly IIletisimAyarService _iletisimAyarService;
        public readonly IMenuService _menuService;
        public readonly ISosyalMedyaAdresService _sosyalMedyaService;

        public HeaderComponent(ISiteAyarService siteAyarService, ISosyalMedyaAdresService sosyalMedyaService, IFtpService ftpService, IIletisimAyarService iletisimAyarService, IMenuService menuService)
        {
            _siteAyarService = siteAyarService;
            _ftpService = ftpService;
            _iletisimAyarService = iletisimAyarService;
            _menuService = menuService;
            _sosyalMedyaService = sosyalMedyaService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            GenelViewModel model = new();
            model.SiteAyar = await _siteAyarService.GetByIdAsync(1);
            model.Ftp = await _ftpService.GetByIdAsync(1);

            model.SosyalMedyaAdresler = await _sosyalMedyaService.GetAllAsync();

            model.Menuler = (await _menuService.GetAllAsync())
     .Where(x => x.MenuYeriId == 1)
     .ToList();
            model.Iletisim = await _iletisimAyarService.GetByAsync(x => x.Varsayilan == true);
            return View(model);
        }
    }
}
