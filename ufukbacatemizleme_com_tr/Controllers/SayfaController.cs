using Kurumsal.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using ufukbacatemizleme_com_tr.Models;

namespace ufukbacatemizleme_com_tr.Controllers
{
    public class SayfaController : Controller
    {
        public readonly ISiteAyarService _siteAyarService;
        public readonly IFtpService _ftpService;
        public readonly IIletisimAyarService _iletisimAyarService;
        public readonly IMenuService _menuService;
        public readonly ISliderService _sliderService;
        public readonly IReferansService _referansService;
        public readonly ISayfaService _sayfaService;

        public SayfaController(ISiteAyarService siteAyarService, IFtpService ftpService, IIletisimAyarService iletisimAyarService, IMenuService menuService, ISliderService sliderService, IReferansService referansService, ISayfaService sayfaService)
        {
            _siteAyarService = siteAyarService;
            _ftpService = ftpService;
            _iletisimAyarService = iletisimAyarService;
            _menuService = menuService;
            _sliderService = sliderService;
            _referansService = referansService;
            _sayfaService = sayfaService;
        }

        public async Task<IActionResult> Index(int id)
        {

            GenelViewModel model = new GenelViewModel();

            var sayfa = await _sayfaService.GetByIdAsync(id);

            if (sayfa == null)
            {
                model.Sayfa=new Kurumsal.Entities.Concrete.Sayfa();
            }
            else
            {
                model.Sayfa=sayfa;
            }

            return View(model);
        }
    }
}
