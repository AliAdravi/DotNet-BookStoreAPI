using BookStore.Data.Models;
using BookStore.Repostitory;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    [Route("api/[controller]")]
    public class PublisherController : Controller
    {
        private readonly IPublisherRepository _publisherRepository;

        public PublisherController(IPublisherRepository pubRepo)
        {
            _publisherRepository = pubRepo;
        }

        [HttpGet("all")]
        public List<Publisher> GetPublishers()
        {
            var Publishers = _publisherRepository.GetPublishers();
            return Publishers.ToList();
        }

        [HttpPost("add")]

        public async Task<IActionResult> Add(Publisher publisher)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(await _publisherRepository.AddPublishers(publisher));
        }


        [HttpPut("edit")]

        public async Task<IActionResult> Edit(Publisher publisher)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(await _publisherRepository.EditPublishers(publisher));
        }



        [HttpDelete("delete")]

        public async Task<IActionResult> Delete(int publisherId)
        {
            if (publisherId < 0)
                return BadRequest(new { message = "Invalid Publisher Id to delete!" });

            var status = await _publisherRepository.DeletePublishers(publisherId);

            return Ok(new { status = status });
        }
    }
}
