using FiorelloMVCProject.Services.Interfaces;
using FiorelloMVCProject.ViewsModel.Category;
using FiorelloMVCProject.ViewsModel.Product;
using Microsoft.AspNetCore.Mvc;

namespace FiorelloMVCProject.ViewComponents
{
    public class ProductViewComponent : ViewComponent
    {
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;

        public ProductViewComponent(IProductService productService, ICategoryService categoryService)
        {
            _categoryService = categoryService;
            _productService = productService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categories = await _categoryService.GetAllAsync();
            var products = await _productService.GetAllAsync();
            ProductVMVC productVMVC = new ProductVMVC
            {
                Categories = categories,
                Products = products
            };

            return View(productVMVC);
        }
    }

    public class ProductVMVC
    {
        public IEnumerable<ProductUIVM> Products { get; set; }
        public IEnumerable<CategoryUIVM> Categories { get; set; }
    }
}
