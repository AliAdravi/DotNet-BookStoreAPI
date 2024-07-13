using BookStore.Data;
using BookStore.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Repostitory
{
    /// <summary>
    /// PublisherRepository
    /// </summary>
    public class PublisherRepository: IPublisherRepository
    {
        private readonly DataContext _dbContext;

        public PublisherRepository(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<Publisher> GetPublishers()
        {
            return _dbContext.Publishers.AsQueryable();
        }

        public async Task<Publisher> AddPublishers(Publisher publisher)
        {
            publisher.Id = 0;
            await _dbContext.Publishers.AddAsync(publisher);
            await _dbContext.SaveChangesAsync();
            return publisher;
        }

        public async Task<Publisher> EditPublishers(Publisher publisher)
        {
            var dbPublisher = await _dbContext.Publishers.FirstOrDefaultAsync(x => x.Id == publisher.Id);
            if (dbPublisher == null)
                throw new Exception("Publisher Not Found!");

            dbPublisher.Name = publisher.Name;
            await _dbContext.SaveChangesAsync();

            return dbPublisher;
        }

        public async Task<bool> DeletePublishers(int publisherId)
        {
            var dbPublisher = await _dbContext.Publishers.FirstOrDefaultAsync(x => x.Id == publisherId);
            if (dbPublisher == null)
                throw new Exception("Publisher Not Found!");
            _dbContext.Publishers.Remove(dbPublisher);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
}
