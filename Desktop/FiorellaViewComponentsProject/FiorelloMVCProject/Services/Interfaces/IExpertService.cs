using FiorelloMVCProject.ViewsModel.Expert;

namespace FiorelloMVCProject.Services.Interfaces
{
    public interface IExpertService
    {
        Task<IEnumerable<ExpertUIVM>> GetAllAsync();
    }
}
