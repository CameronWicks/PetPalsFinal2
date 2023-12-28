using PetPals.Shared.Models;
using PetPals.Shared.Responses;
namespace PetPals.Server.Repositories
{
    public interface IProduct
    {
        Task<ServiceResponse> AddProduct(Product model);
        Task<List<Product>> GetAllProducts(bool featuredProducts);

    }
}
