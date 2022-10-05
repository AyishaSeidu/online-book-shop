using Microsoft.AspNetCore.Components;
using OnlineBookShop.Models.DTOs;
using OnlineBookShop.Web.HttpRepositories.Contracts;

namespace OnlineBookShop.Web.Pages.Bases
{
    public class BooksByGenreBase : ComponentBase
    {
        [Parameter]
        public int GenreId { get; set; }

        [Inject]

        public IBookHttpRepo BookHttpRepo { get; set; }

        public IEnumerable<BookReadDTO> BooksByGenre { set; get; }

        public string ErrorMessage { get; set; }

        public string GenreName { get; set; }

        protected override async Task OnParametersSetAsync()
          {
            try
            {
                BooksByGenre = await BookHttpRepo.GetBooksByGenreId(GenreId);
                if (BooksByGenre != null)
                {
                    var anybook = BooksByGenre.FirstOrDefault();
                    if(anybook != null)
                    {
                        GenreName = anybook.GenreName;
                    }
                }
            }
            catch (Exception e)
            {

                ErrorMessage = e.Message;
            }
        }
    }
}
