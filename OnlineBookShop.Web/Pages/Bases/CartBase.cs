﻿using Microsoft.AspNetCore.Components;
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

        protected override async Task OnInitializedAsync()
        {
            try
            {
                CartItems = await CartHttpRepo.GetItems(4);
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

        private void RemoveItem(int id)
        {
            var item = GetCartItem(id);
            CartItems.Remove(item);
        }
    }
}
