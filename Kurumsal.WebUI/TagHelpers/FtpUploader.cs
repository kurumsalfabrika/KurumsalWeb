using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Kurumsal.WebUI.TagHelpers
{
    public class FtpUploader
    {
        public static async Task UploadFileAsync(string fileName, byte[] fileData, string fullPath, string username, string password, int bufferSize = 2048)
        {
            try
            {
                // Ensure the fullPath starts with the "ftp://" scheme
                string uriPrefix = "ftp://";
                if (!fullPath.StartsWith(uriPrefix))
                {
                    fullPath = uriPrefix + fullPath;
                }

                // Create FtpWebRequest with the full path (assumes fullPath is complete including the file name)
                FtpWebRequest reqFTP = (FtpWebRequest)WebRequest.Create(fullPath);
                reqFTP.Credentials = new NetworkCredential(username, password);
                reqFTP.KeepAlive = false;
                reqFTP.Method = WebRequestMethods.Ftp.UploadFile;
                reqFTP.UseBinary = true;
                reqFTP.ContentLength = fileData.Length;

                // Buffer size can be set via method parameter
                byte[] buffer = new byte[bufferSize];
                int contentLen;

                // Upload the file by writing bytes from the file to the FTP stream
                // Upload the file by writing bytes from the file to the FTP stream
                using (Stream reqStream = await reqFTP.GetRequestStreamAsync())
                {
                    using (MemoryStream fileStream = new MemoryStream(fileData))
                    {
                        while ((contentLen = await fileStream.ReadAsync(buffer, 0, bufferSize)) > 0)
                        {
                            await reqStream.WriteAsync(buffer, 0, contentLen);
                        }
                    }
                }

                // Retrieve the response from the server
                using (FtpWebResponse response = (FtpWebResponse)await reqFTP.GetResponseAsync())
                {
                    Console.WriteLine("Upload File Complete, status {0}", response.StatusDescription);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error uploading file: " + e.Message);
                // Consider logging the error or reporting to an external system
            }
        }
   
        public static async Task UploadFileAsync(IFormFile file, string fullPath, string username, string password, int bufferSize = 2048)
        {
            try
            {
                // Ensure the fullPath starts with the "ftp://" scheme
                string uriPrefix = "ftp://";
                if (!fullPath.StartsWith(uriPrefix))
                {
                    fullPath = uriPrefix + fullPath;
                }

                // Create FtpWebRequest with the full path (assumes fullPath is complete including the file name)
                FtpWebRequest reqFTP = (FtpWebRequest)WebRequest.Create(fullPath);
                reqFTP.Credentials = new NetworkCredential(username, password);
                reqFTP.KeepAlive = false;
                reqFTP.Method = WebRequestMethods.Ftp.UploadFile;
                reqFTP.UseBinary = true;
                reqFTP.ContentLength = file.Length;

                // Buffer size can be set via method parameter
                byte[] buffer = new byte[bufferSize];
                int contentLen;

                // Upload the file by writing bytes from the file to the FTP stream
                using (Stream fileStream = file.OpenReadStream())
                using (Stream reqStream = await reqFTP.GetRequestStreamAsync())
                {
                    while ((contentLen = await fileStream.ReadAsync(buffer, 0, bufferSize)) > 0)
                    {
                        await reqStream.WriteAsync(buffer, 0, contentLen);
                    }
                }

                // Retrieve the response from the server
                using (FtpWebResponse response = (FtpWebResponse)await reqFTP.GetResponseAsync())
                {
                    Console.WriteLine("Upload File Complete, status {0}", response.StatusDescription);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error uploading file: " + e.Message);
                // Consider logging the error or reporting to an external system
            }
        }
    }
}
