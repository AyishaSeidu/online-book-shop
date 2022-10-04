using OnlineBookShop.Models.DTOs;
using OnlineBookShop.Web.HttpRepositories.Contracts;
using System.Net.Http.Json;

namespace OnlineBookShop.Web.HttpRepositories
{
    public class GenreHttpRepo : IGenreHttpRepo
    {
        private HttpClient _httpClient;

        public GenreHttpRepo(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<GenreReadDTO>> GetGenres()
        {
            try
            {
                var response = await _httpClient.GetAsync("api/genre");
                
                if (response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return Enumerable.Empty<GenreReadDTO>().ToList();
                    }
                    else
                    {
                        return await response.Content.ReadFromJsonAsync<List<GenreReadDTO>>();
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
    }
}
