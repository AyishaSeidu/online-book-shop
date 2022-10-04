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
                var genres = await _httpClient.GetFromJsonAsync<IEnumerable<GenreReadDTO>>("api/genre");
                return genres;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
