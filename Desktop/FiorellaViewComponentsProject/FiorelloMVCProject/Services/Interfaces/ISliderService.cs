using FiorelloMVCProject.Models;
using FiorelloMVCProject.ViewsModel.Slider;
using FiorelloMVCProject.ViewsModel.SliderInfo;

namespace FiorelloMVCProject.Services.Interfaces
{
    public interface ISliderService
    {
        Task<IEnumerable<SliderUIVM>> GetAllAsync();

    }
}
