using Microsoft.AspNetCore.Mvc;

namespace ufukbacatemizleme_com_tr.ViewComponents
{
    public class SliderComponent : ViewComponent
    {
        public SliderComponent()
        {
            
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
