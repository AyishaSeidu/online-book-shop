using OnlineBookShop.Models.DTOs;
using OnlineBookShop.Web.HttpRepositories.Contracts;
using System.Net.Http.Json;

namespace OnlineBookShop.Web.HttpRepositories
{
    public class BookHttpRepo : IBookHttpRepo
    {
        private readonly HttpClient _httpClient;

        public BookHttpRepo(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<BookReadDTO>> GeAllBooks()
        {
            try
            {
               var books = await _httpClient.GetFromJsonAsync<IEnumerable<BookReadDTO>>("api/books");
                return books;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<BookReadDTO> GetBookk(int id)
        {
            try
            {
                var response = await _httpClient.GetAsync($"api/books/{id}");

                if(response.IsSuccessStatusCode)
                {
                    if(response.StatusCode==System.Net.HttpStatusCode.NoContent)
                    {
                        return default(BookReadDTO);
                    }
                    else
                    {
                        return await response.Content.ReadFromJsonAsync<BookReadDTO>();
                    }
                }
                else
                {
                    var message = await response.Content.ReadAsStringAsync();
                    throw new Exception(message);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<IEnumerable<BookReadDTO>> GetBooksByGenreId(int id)
        {
            try
            {
                var response = await _httpClient.GetAsync($"api/books/{id}/getbooks");

                if (response.IsSuccessStatusCode)
                {
                    if(response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return Enumerable.Empty<BookReadDTO>();
                    }
                    else
                    {
                        return await response.Content.ReadFromJsonAsync<IEnumerable<BookReadDTO>>();
                    }
                }
                else
                {
                    var message = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Http status code - {response.StatusCode}. Message - {message}");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
