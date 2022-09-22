using Newtonsoft.Json;
using OnlineBookShop.Models.DTOs;
using OnlineBookShop.Web.HttpRepositories.Contracts;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;

namespace OnlineBookShop.Web.HttpRepositories
{
    public class CartHttpRepo : ICartHttpRepo
    {
        private readonly HttpClient _httpClient;

        public CartHttpRepo(HttpClient httpClient)
        {
            _httpClient = httpClient;

        }
        public async Task<CartItemReadDTO> AddItem(CartItemCreateDTO item)
        {
            try
            {
                var httpContent = new StringContent(
                    System.Text.Json.JsonSerializer.Serialize(item),
                    Encoding.UTF8,
                    "application/json");
                var response = await _httpClient.PostAsync("api/cart",httpContent);

                if (response.IsSuccessStatusCode)
                {
                    if(response.StatusCode==System.Net.HttpStatusCode.NoContent)
                    {
                        return default(CartItemReadDTO);
                    }

                    return await response.Content.ReadFromJsonAsync<CartItemReadDTO>();
                    
                }
                else
                {
                    var message = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Http status - {response.StatusCode} Message - {message}");
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<CartItemReadDTO>> GetItems(int userID)
        {
            
            try
            {
                var response = await _httpClient.GetAsync($"api/Cart/{userID}/GetItems");
                if (response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return Enumerable.Empty<CartItemReadDTO>().ToList();
                    }
                    else
                    {
                        return await response.Content.ReadFromJsonAsync<List<CartItemReadDTO>>();
                    }
                }
                else
                {
                    var message = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Http status - {response.StatusCode} Message - {message}");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<CartItemReadDTO> DeleteItem(int itemID)
        {
            try
            {
               var response =  await _httpClient.DeleteAsync($"api/Cart/{itemID}");
                if (response.IsSuccessStatusCode)
                {
                    if(response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return default(CartItemReadDTO);
                    }
                    else
                    {
                        return await response.Content.ReadFromJsonAsync<CartItemReadDTO>();
                    }
                }
                else
                {
                    var message = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Http status - {response.StatusCode} Message - {message}");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<CartItemReadDTO> UpdateQuantity(CartItemQtyUpdateDTO updateDTO)
        {
            try
            {
                var jsonRequest = JsonConvert.SerializeObject(updateDTO);
                var requestContent = new StringContent(jsonRequest, Encoding.UTF8, "application/json-patch+json");
                var response = await _httpClient.PatchAsync($"api/Cart/{updateDTO.CartItemId}", requestContent);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<CartItemReadDTO>();
                }
                else
                {
                    var message = response.Content.ReadAsStringAsync();
                    throw new Exception($"Http status - {response.StatusCode} Message - {message}"); 
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
