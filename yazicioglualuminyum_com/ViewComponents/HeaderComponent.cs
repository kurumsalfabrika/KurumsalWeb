using Kurumsal.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using yazicioglualuminyum_com.Models;

namespace yazicioglualuminyum_com.ViewComponents
{
    public class HeaderComponent : ViewComponent
    {
        public readonly ISiteAyarService _siteAyarService;
        public readonly IFtpService _ftpService;
        public readonly IIletisimAyarService _iletisimAyarService;
        public readonly IMenuService _menuService;
        public readonly ISosyalMedyaAdresService _sosyalMedyaAdresService;

        public HeaderComponent(ISiteAyarService siteAyarService, IFtpService ftpService, IIletisimAyarService iletisimAyarService, IMenuService menuService, ISosyalMedyaAdresService sosyalMedyaAdresService)
        {
            _siteAyarService = siteAyarService;
            _ftpService = ftpService;
            _iletisimAyarService = iletisimAyarService;
            _menuService = menuService;
            _sosyalMedyaAdresService = sosyalMedyaAdresService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            GenelViewModel model = new();
            model.SiteAyar = await _siteAyarService.GetByIdAsync(1) ?? new Kurumsal.Entities.Concrete.SiteAyar();
            model.Ftp = await _ftpService.GetByIdAsync(1) ?? new Kurumsal.Entities.Concrete.Ftp();
            model.Menuler = await _menuService.GetAllAsync() ?? Enumerable.Empty<Kurumsal.Entities.Concrete.Menu>();
            model.Iletisim = await _iletisimAyarService.GetByAsync(x => x.Varsayilan == true) ?? new Kurumsal.Entities.Concrete.IletisimAyar();
            model.SosyalMedyaAdresler = (await _sosyalMedyaAdresService.GetAllAsync() ?? new List<Kurumsal.Entities.Concrete.SosyalMedyaAdres>())
                
                .OrderBy(x => x.Sira)
                .ToList();
            return View(model);
        }
    }
}
