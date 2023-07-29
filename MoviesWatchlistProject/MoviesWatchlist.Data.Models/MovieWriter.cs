using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesWatchlist.Data.Models
{
    public class MovieWriter
    {
        [Required]
        [ForeignKey(nameof(Movie))]
        public Guid MovieId { get; set; }
        public Movie Movie { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Writer))]
        public Guid WriterId { get; set; }
        public Writer Writer { get; set; } = null!;
    }
}
