using Microsoft.EntityFrameworkCore;
using MvcTaskProject.Models;

namespace MvcTaskProject.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SliderInfo> SliderInfos { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogImage> BlogImages { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

     
    }
}