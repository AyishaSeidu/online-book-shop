using Microsoft.AspNetCore.Components;
using OnlineBookShop.Models.DTOs;

namespace OnlineBookShop.Web.Pages.Bases
{
    public class BookDisplayBase : ComponentBase
    {
        [Parameter]
        public IEnumerable<BookReadDTO> Books { get; set; }

        //[Parameter]
        //public Task AddCartItem { get; set; }
    }
}
