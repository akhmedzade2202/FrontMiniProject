using FiorelloMVCProject.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FiorelloMVCProject.ViewComponents
{
    public class BlogViewComponent : ViewComponent
    {
        private readonly IBlogService _blogService;

        public BlogViewComponent(IBlogService blogService)
        {
            
            _blogService = blogService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var blogs = await _blogService.GetAllAsync();
            blogs = blogs.Take(3);
            return View(blogs);
        }
    }
}