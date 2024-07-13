using BookStore.Data;
using BookStore.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Repostitory
{
    public class AuthorRepository: IAuthorRepository
    {
        private readonly DataContext _dbContext;

        public AuthorRepository(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<Author> GetAuthors()
        {
            return _dbContext.Authors.AsQueryable();
        }

        public async Task<Author> AddAuthors(Author author)
        {
            var dbAuthor = new Author
            {
                Name = author.Name,
                Age = author.Age
            };
            await _dbContext.Authors.AddAsync(dbAuthor);
            await _dbContext.SaveChangesAsync();
            return dbAuthor;
        }

        public async Task<Author> EditAuthors(Author author)
        {
           var dbAuthor = await _dbContext.Authors.FirstOrDefaultAsync(x => x.Id == author.Id);
            if (dbAuthor == null)
                throw new Exception("Author Not Found!");

            dbAuthor.Name = author.Name;
            dbAuthor.Age = author.Age;
            await _dbContext.SaveChangesAsync();

            return dbAuthor;
        }

        public async Task<bool> DeleteAuthors(int authorId)
        {
            var dbAuthor = await _dbContext.Authors.FirstOrDefaultAsync(x => x.Id == authorId);
            if (dbAuthor == null)
                throw new Exception("Author Not Found!");
            _dbContext.Authors.Remove(dbAuthor);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
}