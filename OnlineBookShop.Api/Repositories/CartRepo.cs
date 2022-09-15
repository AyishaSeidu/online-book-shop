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

        public Task<CartItem> DeleteItem(int cartID)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<CartItem>> GetCartItems(int userID)
        {
            //var items = await (from item in _dbContext.CartItems
            //                   join cart in _dbContext.Carts on item.CartID equals cart.Id
            //                   join user in _dbContext.Users on cart.UserID equals user.Id
            //                   where cart.UserID == userID
            //                   select new CartItem
            //                   {
            //                       Id = item.Id,
            //                       CartID = cart.Id,
            //                       BookID = item.BookID,
            //                       Quantity = item.Quantity,
            //                       Book = item.Book,
            //                   }
            //                   ).ToListAsync();
            //Console.WriteLine(items);
            var items = await _dbContext.CartItems.Include(c => c.Cart).Where(c=>c.Cart.UserID==userID).Include(c => c.Book).ThenInclude(b => b.Author).ToListAsync();
            return items;
            //var items = await _dbContext.CartItems.Include(cartitem => cartitem.Cart).Where(cartitem=>cartitem.Cart.Wh)
        }

        public async Task<CartItem> GetItem(int cartID)
        {
            return await _dbContext.CartItems.Include(c => c.Book).Where(c => c.CartID == cartID).Include(c=>c.Book).ThenInclude(b=>b.Author).FirstOrDefaultAsync();
        }

        public Task<CartItem> UpdateItemQuantity(int cartID, CartItemQtyUpdateDTO quantity)
        {
            throw new NotImplementedException();
        }
    }
}
