using Microsoft.AspNetCore.Mvc;

namespace MvcPrac.ViewComponents
{
    public class FeatureViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }

    }
}
