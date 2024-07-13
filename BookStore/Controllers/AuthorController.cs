using BookStore.Data.Models;
using BookStore.Repostitory;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    [Route("api/[controller]")]
    
    public class AuthorController : Controller
    {
        private readonly IAuthorRepository _authorRepository;

        public AuthorController(IAuthorRepository authRepo)
        {
            _authorRepository = authRepo;
        }

        [HttpGet("all")]
        public List<Author> GetAuthors()
        {
            var authors = _authorRepository.GetAuthors();
            return authors.ToList();
        }

        [HttpPost("add")]

        public async Task<IActionResult> Add([FromBody]Author author)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var authors = await _authorRepository.AddAuthors(author);

            return Ok(authors);
        }


        [HttpPut("edit")]

        public async Task<IActionResult> Edit([FromBody] Author author)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (author.Id < 0)
                return BadRequest(new { message = "Invalid author Id to update!" });

            var authors = await _authorRepository.EditAuthors(author);

            return Ok(authors);
        }



        [HttpDelete("delete")]

        public async Task<IActionResult> Delete(int authorId)
        {
            if (authorId < 0)
                return BadRequest(new { message = "Invalid author Id to delete!" });

            var status = await _authorRepository.DeleteAuthors(authorId);

            return Ok(new { status = status });
        }
    }
}
