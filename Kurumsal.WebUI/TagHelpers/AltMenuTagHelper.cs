using Kurumsal.Business.Abstract;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurumsal.WebUI.TagHelpers
{



    [HtmlTargetElement("AltMenu")]
    public class AltMenuTagHelper : TagHelper
    { 
        public int AnaMenuId { get; set; }
        public string AnaKategoriAdi { get; set; }
        private readonly IMenuService _menuService;
        public AltMenuTagHelper(IMenuService menuService)
        {
            _menuService = menuService;
        }



        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            var altMenuler = await _menuService.GetAllAsync();

            var builder = new StringBuilder();
            foreach (var item in altMenuler)
            {
                builder.Append($"<tr>");
                builder.Append($"<td>{item.AnaMenuId}</td>");
                builder.Append($"<td><b>{AnaKategoriAdi}</b> > {item.MenuAdi}</td>");
                builder.Append($"<td><button class=\"btn btn-danger\" onclick=\"deleteItem({item.Id})\" title=\"Sil\" ><i class=\"mdi mdi-delete\" ></i></button> <a href=\"\\Menu\\AddOrUpdate\\{item.Id}\"  class=\"btn btn-success\" title=\"Düzenle\" ><i class=\"mdi mdi-clipboard-edit\" ></i></a></td>");
                builder.Append($"</tr>");
            }

            output.Content.SetHtmlContent(builder.ToString());
        }



    }
}
