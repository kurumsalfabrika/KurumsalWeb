using ImageMagick;
using Microsoft.AspNetCore.Http;
using System;
using System.IO;

namespace Kurumsal.WebUI.Context
{
    public class GeneralFunctions
    {

        const int quality = 75;
        public static string ImageUpload(IFormFile dosya)
        {
            var path = $@"Files/Images/";
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            var uzanti = Path.GetExtension(dosya.FileName);
            var resimAd = Guid.NewGuid() + uzanti;
            var kaydedilecekYer = path + resimAd;
            using var stream = new FileStream(kaydedilecekYer, FileMode.Create);
            dosya.CopyTo(stream);


            Resized(kaydedilecekYer, path + "k_400-" + resimAd, 400);
            Resized(kaydedilecekYer, path + "k_200-" + resimAd, 200);
            Resized(kaydedilecekYer, path + "k_600-" + resimAd, 600);
            Resized(kaydedilecekYer, path + "k_800-" + resimAd, 800);
            Resized(kaydedilecekYer, path + "k_150-" + resimAd, 150);
            return resimAd;
        }

        public static void Resized(string anaDosya, string resizedPath, int size)
        {
            using (var image = new MagickImage(anaDosya))
            {
                int width, height;
                if (image.Width > image.Height)
                {
                    width = size;
                    height = Convert.ToInt32(image.Height * size / (double)image.Width);
                }
                else
                {
                    width = Convert.ToInt32(image.Width * size / (double)image.Height);
                    height = size;
                }

                image.Resize(width, height);
                image.Strip();
                image.Quality = quality;
                image.Write(resizedPath);
            }
        }
    }
}
