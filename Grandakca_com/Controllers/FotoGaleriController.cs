using Grandakca_com.Models;
using Kurumsal.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Grandakca_com.Controllers
{
    public class FotoGaleriController : Controller
    {
       
        public readonly IFotografService _fotografService;
        public readonly IFotoGaleriService _fotoGaleriService;
        public readonly IFtpService _ftpService;

        public FotoGaleriController( IFtpService ftpService,  IFotografService fotografService, IFotoGaleriService fotoGaleriService)
        {
            _ftpService = ftpService;
            _fotografService = fotografService;
            _fotoGaleriService = fotoGaleriService;
        }
        public async Task<IActionResult> Index()
        {
            var model = new FotoGaleriViewModel();

            var ftpBilgileri = await _ftpService.GetByIdAsync(1);

            model.Ftp = ftpBilgileri;

            var fotogaleriler = await _fotoGaleriService.GetAllAsync(x => x.ListeKodu == "FOTOGALERI");
            var fotgraflar = await _fotografService.GetAllAsync();

            model.FotoGaleriler = fotogaleriler;
            model.Fotograflar = fotgraflar;


            return View(model);
        }
    }
}
