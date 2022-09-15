using OnlineBookShop.Api.Models;
using OnlineBookShop.Models.DTOs;

namespace OnlineBookShop.Api.Profiles
{
    public class BookProfile : AutoMapper.Profile
    {
        public BookProfile()
        {
            CreateMap<Book, BookReadDTO>()
                .ForMember(dest => dest.AuthorName, opt => opt.MapFrom(src => src.Author.FullName))
                .ForMember(dest => dest.GenreName, opt => opt.MapFrom(src => src.Genre.Name));
        }
    }
}
