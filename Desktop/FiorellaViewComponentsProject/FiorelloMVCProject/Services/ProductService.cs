using FiorelloMVCProject.Data;
using FiorelloMVCProject.Services.Interfaces;
using FiorelloMVCProject.ViewsModel.Product;
using Microsoft.EntityFrameworkCore;

namespace FiorelloMVCProject.Services
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext _context;

        public ProductService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<ProductUIVM>> GetAllAsync()
        {
            var products = await _context.Products.Include(m => m.ProductImages).Select(p => new ProductUIVM
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price,
                CategoryId = p.CategoryId,
                Image = p.ProductImages!.FirstOrDefault(m => m.IsMain).Image
            }).ToListAsync();
            return products;

        }
    }
}
