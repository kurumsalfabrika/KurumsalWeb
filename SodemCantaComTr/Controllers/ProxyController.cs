using Microsoft.AspNetCore.Mvc;

namespace SodemCantaComTr.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProxyController : ControllerBase
    {
        private readonly HttpClient _httpClient;

        public ProxyController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        [HttpGet("image")]
        public async Task<IActionResult> GetImage([FromQuery] string url)
        {
            if (string.IsNullOrEmpty(url))
            {
                return BadRequest("URL is required");
            }

            try
            {
                var response = await _httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();
                var content = await response.Content.ReadAsByteArrayAsync();
                return File(content, "image/jpeg");
            }
            catch (HttpRequestException)
            {
                return BadRequest("Error fetching image from URL");
            }
        }
    }
}
