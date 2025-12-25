using Microsoft.AspNetCore.Mvc;

namespace MvcPrac.ViewComponents
{
    public class FactViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
