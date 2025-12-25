using FiorelloMVCProject.ViewsModel.Product;

namespace FiorelloMVCProject.Services.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<ProductUIVM>> GetAllAsync();
    }
}
