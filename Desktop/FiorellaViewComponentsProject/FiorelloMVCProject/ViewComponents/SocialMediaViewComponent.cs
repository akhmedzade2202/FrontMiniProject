using Microsoft.AspNetCore.Mvc;

namespace FiorelloMVCProject.ViewComponents
{
    public class SocialMediaViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}