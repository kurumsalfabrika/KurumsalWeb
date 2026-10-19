using Microsoft.AspNetCore.Mvc;

namespace ufukbacatemizleme_com_tr.ViewComponents
{
    public class HeadComponent : ViewComponent
    {
        public HeadComponent()
        {
            
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
