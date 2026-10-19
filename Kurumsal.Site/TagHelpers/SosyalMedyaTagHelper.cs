using Kurumsal.Business.Abstract;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Kurumsal.Site.TagHelpers
{
    [HtmlTargetElement("sosyal-medya-tag")]
    public class SosyalMedyaTagHelper : TagHelper
    {
        private readonly ISosyalMedyaAdresService _sosyalMedyaAdresService;
        private readonly IFtpService _ftpService;
        private readonly ISiteAyarService _siteAyarService;
        public SosyalMedyaTagHelper(ISosyalMedyaAdresService sosyalMedyaAdresService, IFtpService ftpService, ISiteAyarService siteAyarService)
        {
            _sosyalMedyaAdresService = sosyalMedyaAdresService;
            _ftpService = ftpService;
            _siteAyarService = siteAyarService;
        }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            var sosyalMedyaAdresler = await _sosyalMedyaAdresService.GetAllAsync();
            var ftpBilgileri = await _ftpService.GetByIdAsync(1);
            var siteAyar = await _siteAyarService.GetByIdAsync(1);

            output.TagName = "ul"; // Eğer hiçbir wrapper tag kullanmak istemiyorsanız bu doğru, aksi halde div gibi bir tag kullanabilirsiniz.
            output.Attributes.SetAttribute("", ""); // Boş attribute kullanımı gereksizdir.

            var content = "";

            foreach (var menu in sosyalMedyaAdresler.OrderBy(x => x.Sira))
            {

                content += $"<li><a href=\"{menu.Url}\" target=\"_blank\" class=\"white-icon\"> <i class=\"{menu.Ikon}\"></i></a></li>";
               
            }

                output.Content.SetHtmlContent(content);
        }
    }
}
