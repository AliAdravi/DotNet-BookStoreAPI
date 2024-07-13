using BookStore.Data.Models;

namespace BookStore.Repostitory
{
    public interface IBookRepository
    {
        IQueryable<Book> GetBooks();
        Task<Book> AddBook(Book book);
        Task<Book> EditBook(Book book);
        Task<bool> DeleteAuthors(int bookId);
    }
}
