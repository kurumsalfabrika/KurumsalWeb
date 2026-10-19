using Kurumsal.Business.Abstract;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Text;
using System.Threading.Tasks;

namespace Kurumsal.WebUI.TagHelpers
{


    [HtmlTargetElement("GirisLogoTag")]
    public class GirisLogoTagHelper : TagHelper
    {
        public int AnaMenuId { get; set; }
        public string AnaKategoriAdi { get; set; }
        private readonly IFtpService _ftpService;
        private readonly ISiteAyarService _siteAyarService;
        public GirisLogoTagHelper(ISiteAyarService siteAyarService, IFtpService ftpService)
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
                builder.Append(@$"        <img src=""{ftpAyar.DosyaAdresOnEki}{logo.FooterLogo}"" alt="""" height=""20"" class=""auth-logo logo-dark mx-auto"">
                            <img src=""{ftpAyar.DosyaAdresOnEki}{logo.FooterLogo}"" alt="""" height=""20"" class=""auth-logo logo-light mx-auto"">");
            }
            else
            {
                builder.Append(@$"        <img src="""" alt="""" height=""20"" class=""auth-logo logo-dark mx-auto"">
                            <img src="""" alt="""" height=""20"" class=""auth-logo logo-light mx-auto"">");
            }



            output.Content.SetHtmlContent(builder.ToString());
        }



    }
}
