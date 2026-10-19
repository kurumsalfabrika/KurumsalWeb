using Kurumsal.Business.Abstract;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Text;
using System.Threading.Tasks;

namespace Kurumsal.WebUI.TagHelpers
{

    [HtmlTargetElement("LogoTag")]
    public class LogoTagHelper : TagHelper
    {
        public int AnaMenuId { get; set; }
        public string AnaKategoriAdi { get; set; }
        private readonly IFtpService _ftpService;
        private readonly ISiteAyarService _siteAyarService;
        public LogoTagHelper(ISiteAyarService siteAyarService, IFtpService ftpService)
        {
            _siteAyarService = siteAyarService;
            _ftpService = ftpService;
        }



        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            var logo = await _siteAyarService.GetByIdAsync(1);
            var ftpAyar = await _ftpService.GetByIdAsync(1);
            var builder = new StringBuilder();

            if (!string.IsNullOrWhiteSpace(ftpAyar?.DosyaAdresOnEki) && !string.IsNullOrWhiteSpace(logo?.FooterLogo))
            {
                builder.Append(@$"<span class=""logo-sm"">
            <img src=""{ftpAyar.DosyaAdresOnEki}{logo.FooterLogo}"" alt=""logo-sm-dark"" height=""22"">
        </span>
        <span class=""logo-lg"">
            <img src=""{ftpAyar.DosyaAdresOnEki}{logo.FooterLogo}"" alt=""logo-dark"" height=""20"">
        </span>");
            }
            else
            {
                builder.Append(@$"<span class=""logo-sm"">
            <img src="""" alt=""logo-sm-dark"" height=""22"">
        </span>
        <span class=""logo-lg"">
            <img src="""" alt=""logo-dark"" height=""20"">
        </span>");
            }

            output.Content.SetHtmlContent(builder.ToString());
        }
    }
}
