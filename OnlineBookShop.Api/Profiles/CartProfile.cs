using AutoMapper;
using OnlineBookShop.Api.Models;
using OnlineBookShop.Models.DTOs;

namespace OnlineBookShop.Api.Profiles
{
    public class CartProfile : Profile
    {
        public CartProfile()
        {
            CreateMap<CartItem, CartItemReadDTO>()
                .ForMember(dest => dest.BookTitle, opt => opt.MapFrom(src => src.Book.Title))
                .ForMember(dest=> dest.AuthorName, opt=> opt.MapFrom(src=> src.Book.Author.FullName))
                .ForMember(dest=>dest.ImageURL, opt=>opt.MapFrom(src=>src.Book.ImageURL))
                .ForMember(dest=>dest.Price, opt=>opt.MapFrom(src=>src.Book.Price))
                .ForMember(dest=>dest.TotalPrice, opt=>opt.MapFrom(src=>src.Quantity*src.Book.Price));
        }
    }
}
