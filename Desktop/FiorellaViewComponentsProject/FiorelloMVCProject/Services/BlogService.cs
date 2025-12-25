using FiorelloMVCProject.Data;
using FiorelloMVCProject.Models;
using FiorelloMVCProject.Services.Interfaces;
using FiorelloMVCProject.ViewsModel.Blog;
using Microsoft.EntityFrameworkCore;

namespace FiorelloMVCProject.Services
{
    public class BlogService : IBlogService
    {
        private readonly ApplicationDbContext _context;

        public BlogService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<BlogUIVM>> GetAllAsync()
        {
            var blogs = await _context.Blogs.Include(b => b.Images)
                .Select(m=> new BlogUIVM
                {
                    Id = m.Id,
                    Title = m.Title,
                    Description = m.Description,
                    Image = m.Images.FirstOrDefault(i => i.Ismain).Image,
                    CreatedDate = m.CreatedDate

                })
                .ToListAsync();
            return blogs;
        }

        public async Task<BlogDetailVM> GetBlogById(int? id)
        {
            var blog = await _context.Blogs.Include(b => b.Images)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (blog == null) return null;

            return new BlogDetailVM
            {
                Id = blog.Id,
                Title = blog.Title,
                Description = blog.Description,
                TeacherName = blog.TeacherName,
                CreatedDate = blog.CreatedDate,
                BlogImage = blog.Images
                    .Where(i => i.Ismain)
                    .Select(i => new BlogImageUIVM
                    {
                        Image = i.Image,
                        Ismain = i.Ismain
                    })
                    .FirstOrDefault()
            };
        }
    }
}
