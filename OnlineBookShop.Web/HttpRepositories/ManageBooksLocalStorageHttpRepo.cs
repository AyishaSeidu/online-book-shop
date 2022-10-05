using Blazored.LocalStorage;
using OnlineBookShop.Models.DTOs;
using OnlineBookShop.Web.HttpRepositories.Contracts;

namespace OnlineBookShop.Web.HttpRepositories
{
    public class ManageBooksLocalStorageHttpRepo : IManageBooksLocalStorageHttpRepo
    {
        private ILocalStorageService _localStorageService;
        private IBookHttpRepo _bookHttpRepo;

        public ManageBooksLocalStorageHttpRepo(ILocalStorageService localStorageService, IBookHttpRepo bookHttpRepo)
        {
            _localStorageService = localStorageService;
            _bookHttpRepo = bookHttpRepo;
        }

        const string BooksKey = "BookCollection";
        public async Task<IEnumerable<BookReadDTO>> GetCollection()
        {
            return await _localStorageService.GetItemAsync<IEnumerable<BookReadDTO>>(BooksKey) ?? await AddCollection();
        }

        public async Task RemoveCollection()
        {
            await _localStorageService.RemoveItemAsync(BooksKey);
        }

        private async Task<IEnumerable<BookReadDTO>> AddCollection()
        {
            var bookCollection = await _bookHttpRepo.GeAllBooks();

            if(bookCollection != null)
            {
                await _localStorageService.SetItemAsync(BooksKey, bookCollection);
            }
            return bookCollection;
        }
    }
}
