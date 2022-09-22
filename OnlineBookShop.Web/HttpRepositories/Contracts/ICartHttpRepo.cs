using OnlineBookShop.Models.DTOs;

namespace OnlineBookShop.Web.HttpRepositories.Contracts
{
    public interface ICartHttpRepo
    {
        public Task<List<CartItemReadDTO>> GetItems(int UserID);
        public Task<CartItemReadDTO> AddItem(CartItemCreateDTO item);

        public Task<CartItemReadDTO> UpdateQuantity(CartItemQtyUpdateDTO updateDTO);
        public Task<CartItemReadDTO> DeleteItem(int id);
    }
}
