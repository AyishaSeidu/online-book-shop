using Microsoft.EntityFrameworkCore;
using OnlineBookShop.Api.Data;
using OnlineBookShop.Api.Models;

namespace OnlineBookShop.Api.Repositories
{
    public class GenreRepo : IGenreRepo
    {
        private ShopDbContext _dbContext;

        public GenreRepo(ShopDbContext shopDBContext)
        {
            _dbContext = shopDBContext;
        }
        public async Task<IEnumerable<Genre>> GetGenres()
        {
            return await _dbContext.Genres.ToListAsync();
        }
    }
}
