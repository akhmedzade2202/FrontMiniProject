using Microsoft.AspNetCore.Mvc;

namespace MvcPrac.ViewComponents
{
    public class VesitableViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
