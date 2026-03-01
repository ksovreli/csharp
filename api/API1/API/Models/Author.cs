using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    [Table("author")]
    public class Author
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [Column("first_name")]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        [Column("last_name")]
        public string LastName { get; set; } = string.Empty;

        [Column("books")]

        public IEnumerable<Book> Books = new List<Book>();
    }
}
