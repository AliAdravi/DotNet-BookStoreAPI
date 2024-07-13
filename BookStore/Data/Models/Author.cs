using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Data.Models
{
    [Table("Author")]
    public class Author
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
       
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [MaxLength(100, ErrorMessage = "Name should not be more than 30 char.")]
        public string Name { get; set; } = default!;
        [Required(ErrorMessage = "Age is required.")]
        [Range(18D, 90D, ErrorMessage = "Age must be between 18 to 90")]
        public int Age { get; set; }
        public ICollection<Book> Books { get; set; } = default!;
    }
}
