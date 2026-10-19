using Newtonsoft.Json;

namespace Kurumsal.DumanSafir.WebUI.Services
{
    public class GoogleReCaptchaService
    {
        private readonly IConfiguration _configuration;
        private readonly IHttpClientFactory _httpClientFactory;

        public GoogleReCaptchaService(IConfiguration configuration, IHttpClientFactory httpClientFactory)
        {
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }

        public async Task<bool> VerifyCaptcha(string token)
        {
            var secret = _configuration["GoogleReCaptcha:SecretKey"];
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetStringAsync($"https://www.google.com/recaptcha/api/siteverify?secret={secret}&response={token}");
            dynamic result = JsonConvert.DeserializeObject(response);
            return result.success == "true";
        }
    }

}
