using OnlineBookShop.Models.DTOs;

namespace OnlineBookShop.Web.HttpRepositories.Contracts
{
    public interface IManageCartLocalStorageHttpRepo
    {
        Task<List<CartItemReadDTO>> GetCollection();
        Task SaveCollection(List<CartItemReadDTO> items);
        Task RemoveCollection();

      
    }
}
