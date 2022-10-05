using Microsoft.AspNetCore.Components;
using OnlineBookShop.Models.DTOs;
using OnlineBookShop.Web.HttpRepositories.Contracts;

namespace OnlineBookShop.Web.Pages.Bases
{
    public class BooksByGenre : ComponentBase
    {
        [Parameter]
        public int GenreId { get; set; }

        [Inject]

        public IBookHttpRepo BookHttpRepo { get; set; }

        public IEnumerable<BookReadDTO> Books { set; get; }

        public string ErrorMessage { get; set; }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                Books = await BookHttpRepo.GetBooksByGenreId(GenreId);
            }
            catch (Exception e)
            {

                ErrorMessage = e.Message;
            }
        }
    }
}
