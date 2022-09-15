using OnlineBookShop.Api.Models;
using OnlineBookShop.Models.DTOs;

namespace OnlineBookShop.Api.Repositories
{
    public interface ICartRepo
    {
        public Task<CartItem> AddItem(CartItemCreateDTO cartItem);
        Task<CartItem> UpdateItemQuantity(int cartID, CartItemQtyUpdateDTO quantity);
        Task<CartItem> DeleteItem(int cartID);  
        Task<CartItem> GetItem(int cartID);
        Task<IEnumerable<CartItem>> GetCartItems(int userID);
    }
}
