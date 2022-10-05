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

        [Inject]
        public IManageBooksLocalStorageHttpRepo ManageBooksLocalStorageHttpRepo { get; set; }

        [Inject]
        public IManageCartLocalStorageHttpRepo ManageCartLocalStorageHttpRepo { get; set; }

        private List<CartItemReadDTO> CartItems { get; set; }
        protected override async Task OnInitializedAsync()
        {
            try
            {
                CartItems = await ManageCartLocalStorageHttpRepo.GetCollection();
                Book = await GetBookById(Id);
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
                if(item != null)
                {
                    CartItems.Add(item);
                    await ManageCartLocalStorageHttpRepo.SaveCollection(CartItems);
                }
                NavigationManager.NavigateTo("/cart");

            }
            catch (Exception)
            {

                throw;
            }
        }

        private async Task<BookReadDTO> GetBookById(int id)
        {
            var books = await ManageBooksLocalStorageHttpRepo.GetCollection();
            if(books!= null)
            {
                return books.SingleOrDefault(b => b.Id == id);
            }
            return null;
        }

    }
}
