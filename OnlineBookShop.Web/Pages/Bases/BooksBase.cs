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

        protected override async Task OnInitializedAsync()
        {
            Books = await BookHttpRepo.GeAllBooks();
            var cartItems = await CartHttpRepo.GetItems(HardCoded.UserId);
            var totalQUantity = cartItems.Sum(i => i.Quantity);
            CartHttpRepo.RaiseEventOnCartChange(totalQUantity);
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
    }
}
