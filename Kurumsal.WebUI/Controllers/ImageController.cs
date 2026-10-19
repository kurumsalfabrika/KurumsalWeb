using Kurumsal.Business.Abstract;
using Kurumsal.WebUI.TagHelpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats;
using SixLabors.ImageSharp.Formats.Gif;
using SixLabors.ImageSharp.Formats.Jpeg;
using SixLabors.ImageSharp.Formats.Png;
using SixLabors.ImageSharp.Processing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Kurumsal.WebUI.Controllers
{
    [Route("image")]
    public class ImageController : Controller
    {
        IFtpService _ftpService;
        public ImageController(IFtpService ftpService)
        {
            _ftpService = ftpService;
        }

        [HttpPost("upload")]
        public async Task<IActionResult> UploadImage(IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                return BadRequest("No file uploaded.");
            }
            string extension = Path.GetExtension(file.FileName);
            var ftpBilgilier = await _ftpService.GetByIdAsync(1);
            var uniqueFileName = $"{Guid.NewGuid()}{extension}";
            string fullPath = $"{ftpBilgilier.FtpURL}{ftpBilgilier.FilePath}/{uniqueFileName}";
            await FtpUploader.UploadFileAsync(file, fullPath, ftpBilgilier.UserName, ftpBilgilier.Password);
            var imageUrl = $"{ftpBilgilier.DosyaAdresOnEki}{uniqueFileName}";
            return Json(new { location = imageUrl });
        }
        public static string SanitizeFileName(string fileName)
        {
            // Türkçe karakterlerin ve diğer özel karakterlerin dönüştürülmesi
            Dictionary<char, char> charMap = new Dictionary<char, char>
            {
                { 'ç', 'c' }, { 'Ç', 'C' }, { 'ğ', 'g' }, { 'Ğ', 'G' },
                { 'ı', 'i' }, { 'İ', 'I' }, { 'ö', 'o' }, { 'Ö', 'O' },
                { 'ş', 's' }, { 'Ş', 'S' }, { 'ü', 'u' }, { 'Ü', 'U' },
                { ' ', '-' }, { 'I', 'i' }
            };

            // Türkçe ve özel karakterleri kaldır
            var sanitizedFileName = new StringBuilder();
            foreach (char c in fileName)
            {
                if (charMap.ContainsKey(c))
                    sanitizedFileName.Append(charMap[c]);
                else if (char.IsLetterOrDigit(c) || c == '.' || c == '_')
                    sanitizedFileName.Append(c);
            }

            // Küçük harflere çevir
            return sanitizedFileName.ToString().ToLower();
        }
        private bool IsImageFile(IFormFile file)
        {
            // Resim dosyası uzantıları listesi
            var allowedExtensions = new[] { ".jpg", ".jpeg", ".png", ".gif" };

            // Dosya uzantısını al
            var fileExtension = Path.GetExtension(file.FileName).ToLower();

            // Eğer dosya uzantısı listede ise, resim dosyası olarak kabul et
            return allowedExtensions.Contains(fileExtension);
        }

        // Dosya uzantısına göre ImageEncoder döndürme
        private IImageEncoder GetEncoder(string fileName)
        {
            var extension = Path.GetExtension(fileName).TrimStart('.');
            switch (extension.ToLower())
            {
                case "jpg":
                case "jpeg":
                    return new JpegEncoder();
                case "png":
                    return new PngEncoder();
                case "gif":
                    return new GifEncoder();
                default:
                    throw new NotSupportedException("Desteklenmeyen dosya uzantısı.");
            }
        }

        [HttpPost("uploadasync")]
        public async Task<IActionResult> UploadImageAsync(IFormFile file, string dosyaAdi)
        {
            if (file == null || file.Length == 0)
            {
                throw new ArgumentException("Yüklenmek istenen dosya boş olamaz.");
            }

           


            string extension = Path.GetExtension(file.FileName);
            var ftpBilgilier = await _ftpService.GetByIdAsync(1);

            if (ftpBilgilier == null)
            {
                return BadRequest("FTP bilgileri bulunamadı!");
            }


            if (dosyaAdi == null)
                dosyaAdi = Guid.NewGuid().ToString();


            var uniqueFileName = $"{SanitizeFileName(dosyaAdi)}{extension}";
            string fullPath = $"{ftpBilgilier.FtpURL}{ftpBilgilier.FilePath}/{uniqueFileName}";

           var fileExistResult=  FtpFileExists(fullPath, uniqueFileName, ftpBilgilier.UserName, ftpBilgilier.Password);

            if(fileExistResult == true)
            {
                 uniqueFileName = $"{DateTime.Now.ToString("HH:mm:ss")}{SanitizeFileName(dosyaAdi)}{extension}";
                 uniqueFileName = uniqueFileName.Replace(":","");
                fullPath = $"{ftpBilgilier.FtpURL}{ftpBilgilier.FilePath}/{uniqueFileName}";
            }

            // Dosya yükleme işlemi asenkron olduğu için await kullanılmalı
            await FtpUploader.UploadFileAsync(file, fullPath, ftpBilgilier.UserName, ftpBilgilier.Password);

            var imageUrl = $"{uniqueFileName}";

            if (IsImageFile(file))
            {
                // Resmi ImageSharp kütüphanesi ile yükle
                using (var image = Image.Load(file.OpenReadStream()))
                {
                    // Resmi istenen boyutlara küçült
                    var resizedImage = image.Clone(x => x.Resize(new ResizeOptions
                    {
                        Size = new Size(500, 0), // Yatay boyutu 500 piksele sabitle, dikey boyutu orantılı olarak ayarla
                        Mode = ResizeMode.Max // Orijinal boyut oranını koru
                    }));


                    // Dosya adına '_k' ekleyerek kaydet
                    var newFileName = $"k_{uniqueFileName}";



                    // Yeni dosya adı ile resmi kaydet
                    using (var outputStream = new FileStream(newFileName, FileMode.Create))
                    {
                        // Resmi outputStream'e kaydet
                        resizedImage.Save(outputStream, GetEncoder(newFileName));
                        // Akışı başlangıç konumuna sıfırla
                        outputStream.Seek(0, SeekOrigin.Begin);

                        // Dosyayı kapat
                        outputStream.Close();

                        byte[] fileBytes;
                        using (var memoryStream = new MemoryStream())
                        {
                            // FileStream'u MemoryStream'e kopyala
                            using (var fileStream = new FileStream(newFileName, FileMode.Open))
                            {
                                await fileStream.CopyToAsync(memoryStream);
                            }
                            // MemoryStream'daki verileri bir byte dizisine dönüştür
                            fileBytes = memoryStream.ToArray();
                        }

                        fullPath = $"{ftpBilgilier.FtpURL}{ftpBilgilier.FilePath}/{newFileName}";

                        // FTP'ye yükleme işlemi
                        await FtpUploader.UploadFileAsync(newFileName, fileBytes, fullPath, ftpBilgilier.UserName, ftpBilgilier.Password);
                    }


                    // Yeni dosya adını döndür

                }
            }
            else
            {
                // Eğer dosya bir resim dosyası değilse hata döndür
                return BadRequest("Dosya bir resim dosyası değil.");
            }

            

            return Ok(imageUrl);
        }


        private static bool FtpFileExists(string fullPath, string fileName, string username, string password)
        {
            try
            {

                string uriPrefix = "ftp://";
                if (!fullPath.StartsWith(uriPrefix))
                {
                    fullPath = uriPrefix + fullPath;
                }

                FtpWebRequest request = (FtpWebRequest)WebRequest.Create($"{fullPath}");
                request.Credentials = new NetworkCredential(username, password);
                request.Method = WebRequestMethods.Ftp.GetFileSize;
                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                {
                    // Dosya varsa true döndür
                    return true;
                }
            }
            catch (WebException ex)
            {
                // Dosya yoksa veya başka bir hata oluşmuşsa false döndür
                FtpWebResponse response = (FtpWebResponse)ex.Response;
                if (response.StatusCode == FtpStatusCode.ActionNotTakenFileUnavailable)
                {
                    return false;
                }
                else
                {
                    throw;
                }
            }
        }


    }




}
