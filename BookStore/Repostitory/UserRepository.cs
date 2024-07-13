using BookStore.Data;
using BookStore.Data.dtos;
using BookStore.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Repostitory
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _dbContect;

        public UserRepository(DataContext dbContext) 
        {
            _dbContect = dbContext;
        }
        public async Task<User> Login(LoginDto loginDto)
        {
            var user = await _dbContect.Users.FirstOrDefaultAsync(x=> x.Email == loginDto.Email && x.Password == loginDto.Password);
            if (user == null)
                throw new ArgumentException("Invalid credentials!");

            return user;
        }

        public async Task<User> Register(User user)
        {
            user.IsActive = true;
            try
            {
                await _dbContect.Users.AddAsync(user);
                await _dbContect.SaveChangesAsync();
                return user;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> IsEmailTaken(string email)
        {
            var user = await _dbContect.Users.FirstOrDefaultAsync(x => x.Email == email);
            if (user == null)
                return false;

            return true;
        }
    }
}
