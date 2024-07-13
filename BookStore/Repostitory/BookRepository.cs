using BookStore.Data;
using BookStore.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Repostitory
{
    public class BookRepository : IBookRepository
    {
        private readonly DataContext _dbContext;

        public BookRepository(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<Book> GetBooks()
        {
            return _dbContext.Books.AsQueryable();
        }

        public async Task<Book> AddBook(Book book)
        {
            book.Id = 0;
            await _dbContext.Books.AddAsync(book);
            await _dbContext.SaveChangesAsync();
            return book;
        }


        public async Task<Book> EditBook(Book book)
        {
            var dbBook = await _dbContext.Books.FirstOrDefaultAsync(x => x.Id == book.Id);
            if (dbBook == null)
                throw new Exception("Book Not Found!");

            dbBook.Name = book.Name;
            dbBook.Pages = book.Pages;
            dbBook.Rating = book.Rating;
            dbBook.Price = book.Price;
            dbBook.PublisherId = book.PublisherId;
            dbBook.PubDate = book.PubDate;
            await _dbContext.SaveChangesAsync();
            return book;

        }
        public async Task<bool> DeleteAuthors(int bookId)
        {
            var dbBook = await _dbContext.Books.FirstOrDefaultAsync(x => x.Id == bookId);
            if (dbBook == null)
                return false;

            _dbContext.Books.Remove(dbBook);
            await _dbContext.SaveChangesAsync();
            return true;
        }


    }
}
