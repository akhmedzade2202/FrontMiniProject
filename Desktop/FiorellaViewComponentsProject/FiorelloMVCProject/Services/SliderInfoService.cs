using FiorelloMVCProject.Data;
using FiorelloMVCProject.Models;
using FiorelloMVCProject.Services.Interfaces;
using FiorelloMVCProject.ViewsModel.SliderInfo;
using Microsoft.EntityFrameworkCore;

namespace FiorelloMVCProject.Services
{
    public class SliderInfoService : ISliderInfoService
    {
        private readonly ApplicationDbContext _context;
        public SliderInfoService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<SliderInfoUIVM> GetAllAsync()
        {
            var sliderInfo = await _context.SliderInfos
                .Select(si => new SliderInfoUIVM
                {
                    Title = si.Title,
                    Description = si.Description,
                    SignatureImage = si.SignatureImage
                })
                .FirstOrDefaultAsync();
            return sliderInfo;
        }
    }
}
