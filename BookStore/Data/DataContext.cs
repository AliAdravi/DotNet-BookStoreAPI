using BookStore.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace BookStore.Data
{
    public class DataContext: DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new DbInitializer(modelBuilder).Seed();
        }
    }

    public class DbInitializer
    {
        private readonly ModelBuilder _modelBuilder;

        public DbInitializer(ModelBuilder modelBuilder)
        {
            _modelBuilder = modelBuilder;
        }

        public void Seed()
        {
            var authorData = new List<Author>();
            for (int i = 0; i < 50; i++)
                authorData.Add(new Author
                {
                    Id = 1005+ i,
                    Name = Faker.Name.FullName(),
                    Age = Random.Shared.Next(21, 65),
                });
            _modelBuilder.Entity<Author>().HasData(authorData.ToArray());

            var publisherData = new List<Publisher>();
            for (int i = 0; i < 50; i++)
                publisherData.Add(new Publisher
                {
                    Id = 105 + i,
                    Name = Faker.Name.FullName()
                });
            _modelBuilder.Entity<Publisher>().HasData(publisherData.ToArray());

            // Books

            var booksData = new List<Book>();
            for (int i = 0; i < 500; i++)
                booksData.Add(new Book
                {
                    Id = 1000 + i,
                    Name = Faker.Company.Name(),
                    Pages = new Random().Next(50, 350),
                    Price = new Random().Next(10, 100),
                    Rating = new Random().Next(0, 5),
                    PubDate = DateTime.Now.AddYears(new Random().Next(-100, 0)),
                    CreatedOn = DateTime.Now.AddDays(new Random().Next(-100, 0)),
                    UpdatedOn = DateTime.Now.AddDays(new Random().Next(-50, 0)),
                    PublisherId = new Random().Next(105, 154)
                });
            _modelBuilder.Entity<Book>().HasData(booksData.ToArray());
        }
    }
}
