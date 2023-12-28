using PetPals.Shared.Models;
using PetPals.Shared.Responses;
namespace PetPals.Client.Services
{
    public interface ICategoryService
    {
        Action? CategoryAction { get; set; }
        Task<ServiceResponse> AddCategory(Category model);
        Task GetAllCategories();
        List<Category> AllCategories { get; set; }
    }
}
