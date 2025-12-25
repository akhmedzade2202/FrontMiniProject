using FiorelloMVCProject.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FiorelloMVCProject.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService;

        public BlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public async Task<IActionResult> Index()
        {
            var blogs = await _blogService.GetAllAsync();
            return View(blogs);
        }

        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return BadRequest();
            var blog = await _blogService.GetBlogById(id);
            if (blog == null) return NotFound();
            return View(blog);
        }
    }
}
