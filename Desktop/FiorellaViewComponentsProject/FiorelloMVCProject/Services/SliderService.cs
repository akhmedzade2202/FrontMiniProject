using FiorelloMVCProject.Data;
using FiorelloMVCProject.Models;
using FiorelloMVCProject.Services.Interfaces;
using FiorelloMVCProject.ViewsModel.Slider;
using FiorelloMVCProject.ViewsModel.SliderInfo;
using Microsoft.EntityFrameworkCore;

namespace FiorelloMVCProject.Services
{
    public class SliderService : ISliderService
    {
        private readonly ApplicationDbContext _context;
        public SliderService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<SliderUIVM>> GetAllAsync()
        {
            List<SliderUIVM> sliders = await _context.Sliders
                .Select(s => new SliderUIVM
                {
                    Image = s.Image
                })
                .ToListAsync();
            return sliders;
        }
    }
}
