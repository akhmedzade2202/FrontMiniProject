using Microsoft.AspNetCore.Mvc;

namespace MvcPrac.ViewComponents
{
    public class BannerViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }

    }
}
