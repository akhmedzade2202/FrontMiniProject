using Microsoft.AspNetCore.Mvc;

namespace FiorelloMVCProject.ViewComponents
{
    public class SubscribeViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}