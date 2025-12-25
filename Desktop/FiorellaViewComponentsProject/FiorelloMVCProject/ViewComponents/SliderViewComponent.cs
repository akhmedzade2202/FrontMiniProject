using FiorelloMVCProject.Models;
using FiorelloMVCProject.Services.Interfaces;
using FiorelloMVCProject.ViewsModel;
using FiorelloMVCProject.ViewsModel.Slider;
using FiorelloMVCProject.ViewsModel.SliderInfo;
using Microsoft.AspNetCore.Mvc;

namespace FiorelloMVCProject.ViewComponents
{
    public class SliderViewComponent : ViewComponent
    {
        private readonly ISliderInfoService _sliderInfoService;
        private readonly ISliderService _sliderService;
        public SliderViewComponent(ISliderInfoService sliderInfoService, ISliderService sliderService)
        {
            _sliderInfoService = sliderInfoService;
            _sliderService = sliderService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            IEnumerable<SliderUIVM> sliders = await _sliderService.GetAllAsync();
            SliderInfoUIVM sliderInfo = await _sliderInfoService.GetAllAsync();

            SliderVMVC sliderVM = new()
            {
                Sliders = sliders,
                SliderInfo = sliderInfo
            };

            return View(sliderVM);
        }
    }
    
}