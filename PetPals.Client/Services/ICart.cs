using PetPals.Client.PrivateModels;
using PetPals.Shared.Models;
using PetPals.Shared.Responses;

namespace PetPals.Client.Services
{
    public interface ICart
    {
        public Action? CartAction { get; set; }
        public int CartCount { get; set; }
        Task GetCartCount();
        Task<ServiceResponse> AddToCart(Product model, int updateQuantity = 1);
        Task<List<Order>> MyOrders();
        Task<ServiceResponse> DeleteCart(Order cart);
        
        bool IsCartLoaderVisible { get; set; }

    }
}
