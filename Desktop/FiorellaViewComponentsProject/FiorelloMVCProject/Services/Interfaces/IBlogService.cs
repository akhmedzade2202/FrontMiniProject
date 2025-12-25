using FiorelloMVCProject.Models;
using FiorelloMVCProject.ViewsModel.Blog;

namespace FiorelloMVCProject.Services.Interfaces
{
    public interface IBlogService
    {
        Task<IEnumerable<BlogUIVM>> GetAllAsync();
        Task<BlogDetailVM> GetBlogById(int? id);
    }
}
