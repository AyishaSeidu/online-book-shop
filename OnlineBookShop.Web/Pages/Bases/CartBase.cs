using Microsoft.AspNetCore.Components;
using OnlineBookShop.Models.DTOs;
using OnlineBookShop.Web.HttpRepositories.Contracts;

namespace OnlineBookShop.Web.Pages.Bases
{
    public class CartBase : ComponentBase
    {
        [Inject]
        public ICartHttpRepo CartHttpRepo { get; set; }

        [Parameter]
        public int UserID { get; set; }

        public List<CartItemReadDTO> CartItems { get; set; }

        public string ErrorMessage { get; set; }

        public string TotalPrice { get; set; }
        public int TotalQuantity { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Inject]
        public IManageCartLocalStorageHttpRepo ManageCartLocalStorageHttpRepo { get; set; }
        protected override async Task OnInitializedAsync()
        {
            try
            {
                CartItems = await ManageCartLocalStorageHttpRepo.GetCollection();
                CartChanged();
            }
            catch (Exception e)
            {

                ErrorMessage = e.Message;
            }
        }

        protected async Task DeleteItem(int id)
        {
            try
            {
                var cartItem = await CartHttpRepo.DeleteItem(id);
                RemoveItem(id);
                CartChanged();

            }
            catch (Exception)
            {

                throw;
            }
        }

        private CartItemReadDTO GetCartItem(int id)
        {
            return CartItems.FirstOrDefault(c => c.Id == id);
        }

        private void CalculateTotalPrice()
        {
            TotalPrice = CartItems.Sum(ci=>ci.TotalPrice).ToString();
        }

        private void CalculateTotalQuantity()
        {
            TotalQuantity = CartItems.Sum(ci => ci.Quantity);
        }

        private void CalculateCartSummary()
        {
            CalculateTotalPrice();
            CalculateTotalQuantity();
        }
        private async void RemoveItem(int id)
        {
            var item = GetCartItem(id);
            CartItems.Remove(item);
            await ManageCartLocalStorageHttpRepo.SaveCollection(CartItems);
        }

        protected async Task UpdateQuantity(int id, int quantity)
        {
            try
            {
                if (quantity <= 0)
                {
                    quantity = 1;
                }
                    var updateDTO = new CartItemQtyUpdateDTO { CartItemId = id, Quantity=quantity };
                    var item = await CartHttpRepo.UpdateQuantity(updateDTO);  
                    var indexOfItem = CartItems.FindIndex(itm=>itm.Id==id);
                    CartItems[indexOfItem] = item;
                    CartChanged();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private async void CartChanged()
        {
            CalculateCartSummary();
            CartHttpRepo.RaiseEventOnCartChange(TotalQuantity);
            await ManageCartLocalStorageHttpRepo.SaveCollection(CartItems);
        }

        protected void ConfirmPayment()
        {

                NavigationManager.NavigateTo("/checkout");
            
        }
    }
}
