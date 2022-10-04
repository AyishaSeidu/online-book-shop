using Microsoft.AspNetCore.Components;
using OnlineBookShop.Models.DTOs;
using OnlineBookShop.Web.HttpRepositories.Contracts;

namespace OnlineBookShop.Web.Shared
{
    public class BookGenreNavMenuBase :ComponentBase
    {
        [Inject]
        public IGenreHttpRepo GenreHttpRepo { get; set; }   
        public IEnumerable<GenreReadDTO> Genres { get; set; }  
        
        public string ErrorMessage { get; set; }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                Genres = await GenreHttpRepo.GetGenres();
            }
            catch (Exception e)
            {

                ErrorMessage = e.Message;
            }
        }

    }
}
