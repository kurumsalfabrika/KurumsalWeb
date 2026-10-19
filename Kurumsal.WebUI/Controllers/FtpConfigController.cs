using Kurumsal.Business.Abstract;
using Kurumsal.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Kurumsal.WebUI.Controllers
{
    public class FtpConfigController : Controller
    {
        IFtpService _service;

        public FtpConfigController(IFtpService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<Ftp>> GetFtpConfig()
        {
            Ftp ftp = new Ftp();

            try
            {
                ftp =await _service.GetByIdAsync(1);
            }
            catch (System.Exception)
            {

                throw;
            }


            return ftp;
        }
    }
}
