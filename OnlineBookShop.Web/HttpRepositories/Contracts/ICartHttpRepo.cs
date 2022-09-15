using OnlineBookShop.Models.DTOs;

namespace OnlineBookShop.Web.HttpRepositories.Contracts
{
    public interface ICartHttpRepo
    {
        public Task<IEnumerable<CartItemReadDTO>> GetItems(int UserID);
        public Task<CartItemReadDTO> AddItem(CartItemCreateDTO item);
    }
}
