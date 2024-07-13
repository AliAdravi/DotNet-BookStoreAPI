using BookStore.Data.Models;

namespace BookStore.Repostitory
{
    public interface IAuthorRepository
    {
        IQueryable<Author> GetAuthors();
        Task<Author> AddAuthors(Author author);
        Task<Author> EditAuthors(Author author);
        Task<bool> DeleteAuthors(int authorId);
    }
}
