using Microsoft.AspNetCore.Http;
using System;
using System.IO;

namespace Kurumsal.WebUI.Functions
{
    public class GeneralFunctions
    {

        public static string DosyaYukle(string path, IFormFile formFile)
        {
            if (formFile != null)
            {
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);

                var uzanti = Path.GetExtension(formFile.FileName);
                var resimAd = Guid.NewGuid() + uzanti;
                var kaydedilecekYer = path + resimAd;
                using var stream = new FileStream(kaydedilecekYer, FileMode.Create);
                formFile.CopyTo(stream);
                return resimAd;
            }
            return null;
        }
    }
}
