using Microsoft.AspNetCore.Mvc;

namespace MvcPrac.ViewComponents
{
    public class TastimonialViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
