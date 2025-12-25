using FiorelloMVCProject.ViewsModel.Slider;
using FiorelloMVCProject.ViewsModel.SliderInfo;

namespace FiorelloMVCProject.ViewsModel
{
    public class SliderVMVC
    {
            public IEnumerable<SliderUIVM> Sliders { get; set; }
            public SliderInfoUIVM SliderInfo { get; set; }
    }
}
