using Microsoft.AspNetCore.Components;
using OnlineBookShop.Models.DTOs;
using OnlineBookShop.Web.HttpRepositories.Contracts;

namespace OnlineBookShop.Web.Pages.Bases
{
    public class BooksBase : ComponentBase
    {
        [Inject]
        public IBookHttpRepo BookHttpRepo { get; set; }

        [Inject]
        public ICartHttpRepo CartHttpRepo { get; set; }
        public IEnumerable<BookReadDTO> Books { get; set; }

        [Inject]
        public IManageBooksLocalStorageHttpRepo ManageBooksLocalStorageHttpRepo { get; set; }

        [Inject]
        public IManageCartLocalStorageHttpRepo ManageCartLocalStorageHttpRepo { get; set; }
        protected override async Task OnInitializedAsync()
        {
            try
            {
                await ClearLocalStorage();
                Books = await ManageBooksLocalStorageHttpRepo.GetCollection();
                var cartItems = await ManageCartLocalStorageHttpRepo.GetCollection();
                var totalQUantity = cartItems.Sum(i => i.Quantity);
                CartHttpRepo.RaiseEventOnCartChange(totalQUantity);
            }
            catch (Exception)
            {

                throw;
            }

        }

        protected IOrderedEnumerable<IGrouping<int, BookReadDTO>> GetGroupedBooksByGenre()
        {
            return from book in Books
                   group book by book.GenreID into bookByGenreGroup
                   orderby bookByGenreGroup.Key
                   select bookByGenreGroup;
        }

        protected string GetGenreName(IGrouping<int, BookReadDTO> groupedBookDTOs)
        {
            return groupedBookDTOs.FirstOrDefault(g => g.GenreID == groupedBookDTOs.Key).GenreName;
        }

        protected async Task AddToCart(CartItemCreateDTO newCartItem)
        {
            try
            {
                CartHttpRepo.AddItem(newCartItem);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private async Task ClearLocalStorage()
        {
            await ManageBooksLocalStorageHttpRepo.RemoveCollection();
            await ManageCartLocalStorageHttpRepo.RemoveCollection();
        }
    }
}
