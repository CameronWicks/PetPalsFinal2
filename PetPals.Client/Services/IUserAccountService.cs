using PetPals.Shared.DTOs;
using PetPals.Shared.Responses;
namespace PetPals.Client.Services
{
    public interface IUserAccountService
    {
        Task<ServiceResponse> Register(UserDTO model);
        Task<LoginResponse> Login(LoginDTO model);
    }
}
