using OnlineBookShop.Api.Models;
using System.Collections.Generic;

namespace OnlineBookShop.Api.Repositories
{
    public interface IBookRepo
    {
        public Task<IEnumerable<Book>> GetAllBooksAsync();
        public Task<IEnumerable<Author>> GetAuthorsAsync();
        public Task<IEnumerable<Genre>> GetGenresAsync();
        public Task<Book> GetBookByIdAsync(int id);
        public Task<Author> GetAuthorByIdAsync(int id);
        public Task<IEnumerable<Book>> GetBooksByGenreId(int id);
    }
}
