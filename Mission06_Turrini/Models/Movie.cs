using System.ComponentModel.DataAnnotations;

namespace JoelHiltonFilmCollection.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public required string Category { get; set; }

        [Required]
        public required string Title { get; set; }

        [Required]
        public required string Year { get; set; }

        [Required]
        public required string Director { get; set; }

        [Required]
        public required string Rating { get; set; } // Dropdown: G, PG, PG-13, R

        public bool Edited { get; set; } = false; // Set default value

        public string? LentTo { get; set; } // Nullable (optional)

        [MaxLength(25)]
        public string? Notes { get; set; } // Nullable (optional)
    }
}
