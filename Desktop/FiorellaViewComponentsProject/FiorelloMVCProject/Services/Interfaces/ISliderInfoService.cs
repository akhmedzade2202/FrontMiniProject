using FiorelloMVCProject.Models;
using FiorelloMVCProject.ViewsModel.SliderInfo;

namespace FiorelloMVCProject.Services.Interfaces
{
    public interface ISliderInfoService
    {
        Task<SliderInfoUIVM> GetAllAsync();

    }
}
