using BookStore.Data.dtos;
using BookStore.Data.Models;

namespace BookStore.Repostitory
{
    public interface IUserRepository
    {
        Task<User> Register(User user);
        Task<User> Login(LoginDto loginDto);
        Task<bool> IsEmailTaken(string email);
    }
}
