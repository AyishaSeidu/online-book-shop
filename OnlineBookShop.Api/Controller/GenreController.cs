using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OnlineBookShop.Api.Repositories;
using OnlineBookShop.Models.DTOs;

namespace OnlineBookShop.Api.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class GenreController : ControllerBase
    {
        private IGenreRepo _genreRepo;
        private IMapper _mapper;

        public GenreController(IGenreRepo genreRepo, IMapper mapper)
        {
            _genreRepo = genreRepo;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GenreReadDTO>>> GetGenres()
        {
            var genres = await _genreRepo.GetGenres();

            if (genres == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(_mapper.Map<IEnumerable<GenreReadDTO>>(genres));
            }
        }
    }
}
