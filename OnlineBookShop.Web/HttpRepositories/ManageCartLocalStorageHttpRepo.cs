using Blazored.LocalStorage;
using OnlineBookShop.Models.DTOs;
using OnlineBookShop.Web.HttpRepositories.Contracts;

namespace OnlineBookShop.Web.HttpRepositories
{
    public class ManageCartLocalStorageHttpRepo : IManageCartLocalStorageHttpRepo
    {
        private ILocalStorageService _localStorageService;
        private ICartHttpRepo _cartHttpRepo;

        public ManageCartLocalStorageHttpRepo(ILocalStorageService localStorageService,ICartHttpRepo cartHttpRepo)
        {
            _localStorageService = localStorageService;
            _cartHttpRepo = cartHttpRepo;
        }

        const string StorageKey = "cartItems";
        public async Task<List<CartItemReadDTO>> GetCollection()
        {
            return await _localStorageService.GetItemAsync<List<CartItemReadDTO>>(StorageKey) ?? await AddCollection();
        }

        public async Task RemoveCollection()
        {
            await _localStorageService.RemoveItemAsync(StorageKey);
        }

        public async Task SaveCollection(List<CartItemReadDTO> items)
        {
            await _localStorageService.SetItemAsync(StorageKey, items);
        }

        private async Task<List<CartItemReadDTO>> AddCollection()
        {
            var collection = await _cartHttpRepo.GetItems(HardCoded.UserId);
            if(collection != null)
            {
                await _localStorageService.SetItemAsync(StorageKey, collection);
            }
            return collection;
        }
    }
}
