using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JoelHiltonFilmCollection.Models
{
    public class Movie
    {
        public int MovieId { get; set; }

        public int? CategoryId { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]
        public int Year { get; set; }

        [Required]
        public string Director { get; set; } = string.Empty;

        [Required]
        public string Rating { get; set; } = string.Empty;

        [Required]
        public bool Edited { get; set; }

        [Required]
        public bool CopiedToPlex { get; set; }

        public string? LentTo { get; set; }

        [MaxLength(25)]
        public string? Notes { get; set; }
    }
}
