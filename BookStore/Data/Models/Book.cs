using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Data.Models
{
    [Table("Book")]
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; } = default!;
        public int Pages { get; set; }
        public decimal Price { get; set; }
        public int Rating { get; set; }
        public ICollection<Author> Authors { get; set; } = new List<Author>();

        [ForeignKey("Publisher")]
        public int PublisherId { get; set; } = default!;
        public DateTime PubDate { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public DateTime UpdatedOn { get; set; } = DateTime.Now;

    }
}
