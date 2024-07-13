using AutoMapper;
using BookStore.Data.dtos;
using BookStore.Data.Models;

namespace BookStore.Data
{
    public class BookStoreProfile: Profile
    {
        public BookStoreProfile()
        {
            CreateMap<BookDto, Book>();
            CreateMap<RegisterDto, User>();
        }
    }
}
