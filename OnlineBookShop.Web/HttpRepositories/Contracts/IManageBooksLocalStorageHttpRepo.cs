using OnlineBookShop.Models.DTOs;

namespace OnlineBookShop.Web.HttpRepositories.Contracts
{
    public interface IManageBooksLocalStorageHttpRepo
    {
        Task<IEnumerable<BookReadDTO>> GetCollection();

        Task RemoveCollection();
    }
}
