using OnlineBookShop.Models.DTOs;

namespace OnlineBookShop.Web.HttpRepositories.Contracts
{
    public interface IGenreHttpRepo
    {
        Task<IEnumerable<GenreReadDTO>> GetGenres();
    }
}
