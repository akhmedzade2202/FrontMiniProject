using Microsoft.AspNetCore.Mvc;

namespace MvcPrac.ViewComponents
{
    public class BestSalerViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
