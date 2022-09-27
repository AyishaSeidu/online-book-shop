using Microsoft.AspNetCore.Components;
using OnlineBookShop.Models.DTOs;
using OnlineBookShop.Web.HttpRepositories.Contracts;

namespace OnlineBookShop.Web.Pages.Bases
{
    public class BookDetailsBase : ComponentBase
    {
        [Parameter]
        public int Id { get; set; }

        [Inject]
        public IBookHttpRepo HttpBookRepo { get; set; }

        [Inject]
        public ICartHttpRepo CartHttpRepo { get; set; }

        public BookReadDTO Book { set; get; }

        public string ErrorMessage { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                Book = await HttpBookRepo.GetBookk(Id);
            }
            catch (Exception e)
            {

                ErrorMessage = e.Message;
            }
            
        }

        protected async Task AddToCart(CartItemCreateDTO newCartItem)
        {
            try
            {
                var item = await CartHttpRepo.AddItem(newCartItem);
                NavigationManager.NavigateTo("/cart");

            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
