using PetPals.Shared.Models;
using PetPals.Shared.Responses;
namespace PetPals.Server.Repositories
{
    public interface ICategory
    {
        Task<ServiceResponse> AddCategory(Category model);
        Task<List<Category>> GetAllCategories();

    }
}
