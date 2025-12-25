using Microsoft.AspNetCore.Mvc;

public class FeatureSectionViewComponent : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync()
    {
        return View();
    }
}
