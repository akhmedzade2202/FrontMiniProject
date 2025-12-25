using Microsoft.AspNetCore.Mvc;

namespace MvcPrac.Components
{
    public class FruitViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
