using FiorelloMVCProject.ViewsModel.Category;

namespace FiorelloMVCProject.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryUIVM>> GetAllAsync();
    }
}
