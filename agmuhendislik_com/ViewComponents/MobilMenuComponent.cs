using agmuhendislik_com.Models;
using Kurumsal.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace agmuhendislik_com.ViewComponents
{


    public class MobilMenuComponent : ViewComponent
    {
        public readonly ISiteAyarService _siteAyarService;
        public readonly IFtpService _ftpService;
        public readonly IIletisimAyarService _iletisimAyarService;
        public readonly IMenuService _menuService;
        public MobilMenuComponent(ISiteAyarService siteAyarService, IFtpService ftpService, IIletisimAyarService iletisimAyarService, IMenuService menuService)
        {
            _siteAyarService = siteAyarService;
            _ftpService = ftpService;
            _iletisimAyarService = iletisimAyarService;
            _menuService = menuService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            GenelViewModel model = new();
            model.SiteAyar = await _siteAyarService.GetByIdAsync(1);
            model.Ftp = await _ftpService.GetByIdAsync(1);
            model.Menuler = await _menuService.GetAllAsync();
            model.Iletisim = await _iletisimAyarService.GetByAsync(x => x.Varsayilan == true);
            return View(model);
        }
    }

}
