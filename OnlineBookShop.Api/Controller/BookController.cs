using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OnlineBookShop.Api.Models;
using OnlineBookShop.Api.Repositories;
using OnlineBookShop.Models.DTOs;

namespace OnlineBookShop.Api.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly IBookRepo _repository;
        private readonly IMapper _mapper;

        public BooksController(IBookRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<BookReadDTO>>> GetAllBooks()
        {
            try
            {
                var books = await _repository.GetAllBooksAsync();
                //var authors = await _repository.GetAuthorsAsync();
                //var genres = await _repository.GetGenresAsync();
                if (books == null /*|| authors == null || genres == null*/)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(_mapper.Map<List<BookReadDTO>>(books));
                }

            }
            catch (Exception e)
            {

                return NotFound(e.Message);
            }

        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<BookReadDTO>> GetSingleBook(int id)
            {
            try
            {
                var book = await _repository.GetBookByIdAsync(id);
                if (book!=null)
                {
                    return Ok(_mapper.Map<BookReadDTO>(book));
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
            }

        [HttpGet("{genreId}/GetBooks")]
        public async Task<ActionResult<IEnumerable<BookReadDTO>>> GetBooksByGenreId(int genreId)
        {
            try
            {
                var books = await _repository.GetBooksByGenreId(genreId);
                if (books != null)
                {
                    return Ok(_mapper.Map<List<BookReadDTO>>(books));
                }
                else
                {
                    return NotFound();
                }

            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

    }
}
