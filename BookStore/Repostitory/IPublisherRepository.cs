using BookStore.Data.Models;

namespace BookStore.Repostitory
{
    public interface IPublisherRepository
    {
        IQueryable<Publisher> GetPublishers();
        Task<Publisher> AddPublishers(Publisher Publisher);
        Task<Publisher> EditPublishers(Publisher Publisher);
        Task<bool> DeletePublishers(int PublisherId);
    }
}
