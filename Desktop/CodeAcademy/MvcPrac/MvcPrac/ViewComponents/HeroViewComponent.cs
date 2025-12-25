using Microsoft.AspNetCore.Mvc;

namespace MvcPrac.ViewComponents
{
    public class HeroViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
