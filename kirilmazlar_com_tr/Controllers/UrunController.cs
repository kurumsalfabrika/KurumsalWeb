using kirilmazlar_com_tr.Models;
using Kurumsal.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace kirilmazlar_com_tr.Controllers
{
    public class UrunController : Controller
    {
        public readonly IMarkaService _markaService;
        public readonly IUrunService _urunService;
        public readonly IUrunKategoriService _urunKategoriService;
        public readonly IFtpService _ftpService;

        public UrunController(IFtpService ftpService, IMarkaService markaService, IUrunKategoriService urunKategoriService = null, IUrunService urunService = null)
        {
            _ftpService = ftpService;
            _markaService = markaService;
            _urunKategoriService = urunKategoriService;
            _urunService = urunService;
        }
        public async Task<IActionResult> Index()
        {
            var model = new UrunViewModel();

            var ftpBilgileri = await _ftpService.GetByIdAsync(1);
            model.Ftp = ftpBilgileri;

            var markalar = await _markaService.GetAllAsync();
            model.Markalar = markalar;

            var urunKategoriler = await _urunKategoriService.GetAllAsync();
            model.UrunKategorileri= urunKategoriler;

            return View(model);
        }
        public async Task<IActionResult> Detay(int id)
        {
            var model = new UrunViewModel();


            var urunler = await _urunService.GetAllAsync(x=>x.UrunKategoriId == id);

            model.Urunler = urunler;

            var ftpBilgileri = await _ftpService.GetByIdAsync(1);
            model.Ftp = ftpBilgileri;

            var markalar = await _markaService.GetAllAsync();
            model.Markalar = markalar;

            var urunKategori = await _urunKategoriService.GetByIdAsync(id);
            model.UrunKategori = urunKategori;

            var urunKategoriler = await _urunKategoriService.GetAllAsync();
            model.UrunKategorileri= urunKategoriler;

            return View(model);
        }
    }
}
