using FiorelloMVCProject.Data;
using FiorelloMVCProject.Services.Interfaces;
using FiorelloMVCProject.ViewsModel.Expert;
using Microsoft.EntityFrameworkCore;

namespace FiorelloMVCProject.Services
{
    public class ExpertService : IExpertService
    {
        private readonly ApplicationDbContext _context;

        public ExpertService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ExpertUIVM>> GetAllAsync()
        {
            var experts = await _context.Experts.Select(e => new ExpertUIVM
            {
                FullName = e.FullName,
                Positions = e.Positions,
                Image = e.Image
            }).ToListAsync();
            return experts;
        }
    }
}
