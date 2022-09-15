using OnlineBookShop.Models.DTOs;

namespace OnlineBookShop.Web.HttpRepositories.Contracts
{
    public interface IBookHttpRepo
    {
        Task<IEnumerable<BookReadDTO>> GeAllBooks();

        Task<BookReadDTO> GetBookk(int id);
    }
}
