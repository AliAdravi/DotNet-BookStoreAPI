using BookStore.Data.Models;
using BookStore.Repostitory;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    [Route("api/[controller]")]
    public class BookController : Controller
    {
        private readonly IBookRepository _bookRepository;
        public BookController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        [HttpGet("all")]
        public List<Book> GetAllBooks()
        {
            var books = _bookRepository.GetBooks();
            return books.ToList();
        }

        //[HttpPost("add")]

        //public async Task<Book> Add(Book book)
        //{
        //    if (book == null)
        //        throw new ArgumentNullException(nameof(book));

        //    if (string.IsNullOrEmpty(book.Name))
        //        throw new ArgumentNullException(nameof(book.Name));

        //    if (book.Pages < 20)
        //        throw new AggregateException("Book must contain min. 20 pages!");

        //    if (book.Price < 10)
        //        throw new AggregateException("Book price must be more than $10!");


        //    if (book.Publisher)
        //        throw new ArgumentNullException(nameof(book.Name));

        //    var authors = await _authorRepository.AddAuthors(author);

        //    return authors;
        //}
    }
}
