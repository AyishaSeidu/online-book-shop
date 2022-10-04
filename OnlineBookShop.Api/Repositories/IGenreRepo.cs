using OnlineBookShop.Api.Models;

namespace OnlineBookShop.Api.Repositories
{
    public interface IGenreRepo
    {
        public Task<IEnumerable<Genre>> GetGenres();
    }
}
