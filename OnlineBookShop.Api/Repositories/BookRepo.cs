using Microsoft.EntityFrameworkCore;
using OnlineBookShop.Api.Data;
using OnlineBookShop.Api.Models;

namespace OnlineBookShop.Api.Repositories
{
    public class BookRepo : IBookRepo
    {
        private readonly ShopDbContext _dbContext;

        public BookRepo(ShopDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<Book>> GetAllBooksAsync()
        {

                var books = await _dbContext.Books.Include(b=>b.Author).Include(b=> b.Genre).ToListAsync();
                return books;
            
        }

        public Task<Author> GetAuthorByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Author>> GetAuthorsAsync()
        {
            var authors = await _dbContext.Authors.ToListAsync();
            return authors;
        }

        public async Task<Book> GetBookByIdAsync(int id)
        {
            var book = await _dbContext.Books.Include(b=>b.Author).Include(b=> b.Genre).FirstOrDefaultAsync(b => b.Id == id);
            return book;
        }

        public async Task<IEnumerable<Book>> GetBooksByGenreId(int id)
        {
            var books = await _dbContext.Books.Include(b => b.Genre).Where(b => b.GenreID == id).Include(b => b.Author).ToListAsync();
            return books;
        }

        public Task<Genre> GetGenreByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Genre>> GetGenresAsync()
        {
            var genres = await _dbContext.Genres.ToListAsync();
            return genres;
        }
    }
}
