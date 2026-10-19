using Microsoft.AspNetCore.Mvc;

namespace ufukbacatemizleme_com_tr.ViewComponents
{
    public class HeaderMobileComponent : ViewComponent
    {
        public HeaderMobileComponent()
        {
            
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
