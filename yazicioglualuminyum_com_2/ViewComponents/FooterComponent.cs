using Kurumsal.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using yazicioglualuminyum_com_2.Models;

namespace yazicioglualuminyum_com_2.ViewComponents
{
    public class FooterComponent : ViewComponent
    {
        public readonly ISiteAyarService _siteAyarService;
        public readonly IFtpService _ftpService;
        public readonly IIletisimAyarService _iletisimAyarService;
        public readonly IMenuService _menuService;
        public readonly ISosyalMedyaAdresService _sosyalMedyaAdresService;
        public FooterComponent(ISiteAyarService siteAyarService, IFtpService ftpService, IIletisimAyarService iletisimAyarService, IMenuService menuService, ISosyalMedyaAdresService sosyalMedyaAdresService)
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
            model.SiteAyar = await _siteAyarService.GetByIdAsync(1);
            model.Ftp = await _ftpService.GetByIdAsync(1);
            model.Menuler = await _menuService.GetAllAsync();
            model.Iletisim = await _iletisimAyarService.GetByAsync(x => x.Varsayilan == true);
            model.SosyalMedyaAdresler=await _sosyalMedyaAdresService.GetAllAsync(); 
            return View(model);
        }
    }
}
