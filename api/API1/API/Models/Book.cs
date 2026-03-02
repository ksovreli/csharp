using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public enum Genre
    {
        Mystery,
        SciFi,
        Fantasy,
        Biography,
        History,
        Romance,
        Drama,
        Action
    }

    public enum Language
    {
        Japanese,
        English,
        Spanish,
        French,
        German,
        Chinese,
        Russian,
        Arabic
    }

    [Table("books")]
    public class Book
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("title")]
        [StringLength(200, MinimumLength = 1)]
        public string Title { get; set; } = null!;

        [Required]
        [Column("author")]
        [StringLength(100, MinimumLength = 1)]
        public string Author { get; set; } = null!;

        [Required]
        [Column("price", TypeName = "decimal(5, 2)")]
        public decimal Price { get; set; }

        [Column("description")]
        public string? Description { get; set; } = null!;

        [Required]
        [Column("release_date")]
        [Range(1800, 2100)]
        public DateOnly ReleaseDate { get; set; }

        [Required]
        [Column("genre")]
        public Genre Genre { get; set; } = Genre.Mystery;

        [Required]
        [Column("quantity")]
        [Range(0, 100)]
        public uint Quantity { get; set; }

        [Required]
        [Column("page_number")]
        [Range(1, 10000)]
        public uint PageNumber { get; set; }

        [NotMapped]
        public bool isAvailable { get => Quantity > 0; }

        [Required]
        [Column("isbn")]
        [StringLength(13, MinimumLength = 11)]
        public string ISBN { get; set; } = null!;

        [Required]
        [Column("publisher")]
        [StringLength(200, MinimumLength = 1)]
        public string Publisher { get; set; } = null!;

        [Required]
        [Column("translator")]
        public string? Translator { get; set; }

        [Required]
        [Column("language")]
        public Language Language { get; set; }

        [Required]
        [Column("is_original")]
        public bool IsOriginal { get; set; }
    }
}
