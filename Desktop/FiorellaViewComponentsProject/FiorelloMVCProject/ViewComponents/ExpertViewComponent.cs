using FiorelloMVCProject.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FiorelloMVCProject.ViewComponents
{
    public class ExpertViewComponent : ViewComponent
    {
        private readonly IExpertService _expertService;
        public ExpertViewComponent(IExpertService expertService)
        {
            _expertService = expertService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var experts = await _expertService.GetAllAsync();

            return View(experts);
        }
    }
}
