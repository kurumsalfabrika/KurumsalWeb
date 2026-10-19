using Microsoft.AspNetCore.Mvc;

namespace SodemCantaComTr.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DesignController : ControllerBase
    {
        [HttpPost("upload")]
        public async Task<IActionResult> Upload(IFormFile image)
        {
            if (image == null || image.Length == 0)
            {
                return BadRequest("No file uploaded.");
            }

            var uploadPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/upload");
            if (!Directory.Exists(uploadPath))
            {
                Directory.CreateDirectory(uploadPath);
            }

            var fileExtension = Path.GetExtension(image.FileName);
            var fileName = $"{Guid.NewGuid()}{fileExtension}";
            var filePath = Path.Combine(uploadPath, fileName);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await image.CopyToAsync(stream);
            }

            var relativeUrl = $"/upload/{fileName}";

            return Ok(new { url = relativeUrl });
        }
    }
}
