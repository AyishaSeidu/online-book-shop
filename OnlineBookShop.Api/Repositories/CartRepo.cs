using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;
using OnlineBookShop.Api.Data;
using OnlineBookShop.Api.Models;
using OnlineBookShop.Models.DTOs;

namespace OnlineBookShop.Api.Repositories
{
    public class CartRepo : ICartRepo
    {
        private readonly ShopDbContext _dbContext;

        public CartRepo(ShopDbContext shopDBContext)
        {
            _dbContext = shopDBContext;
        }

        private async Task<bool> CartItemExist(int cartID, int bookID)
        {
            return await _dbContext.CartItems.AnyAsync(c=> c.CartID == cartID && c.BookID == bookID);   
        }

        public async Task<CartItem> AddItem(CartItemCreateDTO cartItem)
        {
            try
            {
                if (await CartItemExist(cartItem.CartID, cartItem.BookID) == false)
                {
                    var item = await (from book in _dbContext.Books
                                      where book.Id == cartItem.BookID
                                      select new CartItem
                                      {
                                          CartID = cartItem.CartID,
                                          BookID = book.Id,
                                          Quantity = cartItem.Quantity
                                      }).SingleOrDefaultAsync();
                    if (item != null)
                    {
                        var results = await _dbContext.CartItems.AddAsync(item);
                        await _dbContext.SaveChangesAsync();
                        return results.Entity;
                    }

                }
                return null;

            }
            catch (Exception)
            {

                throw;
            }

        }

        public async Task<CartItem> DeleteItem(int cartItemID)
        {
            var item = await _dbContext.CartItems.FirstOrDefaultAsync(c => c.Id == cartItemID);
            if (item != null)
            {
                _dbContext.CartItems.Remove(item);
                _dbContext.SaveChanges();
                return item;
            }
            return null; 
        }

        public async Task<IEnumerable<CartItem>> GetCartItems(int userID)
        {
            var items = await _dbContext.CartItems.Include(c => c.Cart).Where(c=>c.Cart.UserID==userID).Include(c => c.Book).ThenInclude(b => b.Author).ToListAsync();
            return items;
        }

        public async Task<CartItem> GetItem(int cartID)
        {
            return await _dbContext.CartItems.Include(c => c.Book).Where(c => c.CartID == cartID).Include(c=>c.Book).ThenInclude(b=>b.Author).FirstOrDefaultAsync();
        }

        public async Task<CartItem> UpdateItemQuantity(CartItemQtyUpdateDTO updateDto)
        {
            var item = await _dbContext.CartItems.FirstOrDefaultAsync(ci => ci.Id == updateDto.CartItemId);
            if (item != null)
            {
               item.Quantity = updateDto.Quantity;
                _dbContext.SaveChanges();
                return item;
            }
            else
            {
                return null;
            }
        }

        public async Task<CartItem> UpdateItemQuantityPatch(int itemId, JsonPatchDocument quantityUpdateDTO)
        {
            var item = await _dbContext.CartItems.FindAsync(itemId);

            if(item != null)
            {
               quantityUpdateDTO.ApplyTo(item);
                await _dbContext.SaveChangesAsync();
                return item;
            }
            else
            {
                return null;
            }
        }
    }
}
