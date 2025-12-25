using FiorelloMVCProject.Data;
using FiorelloMVCProject.Services.Interfaces;
using FiorelloMVCProject.ViewsModel.Category;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace FiorelloMVCProject.Services
{
    public class CategoryService : ICategoryService

    {
        private readonly ApplicationDbContext _context;
        public CategoryService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<CategoryUIVM>> GetAllAsync()
        {
            var categories = await _context.Categories.Select(c => new CategoryUIVM
            {
                Id = c.Id,
                Name = c.Name
            }).ToListAsync();

            return  categories;
        }
    }
}
