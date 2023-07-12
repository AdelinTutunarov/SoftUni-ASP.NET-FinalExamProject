using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesWatchlist.Data.Models
{
    public class MovieGenre
    {
        [Required]
        [ForeignKey(nameof(Movie))]
        public int MovieId { get; set; }
        public Movie Movie { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Genre))]
        public int GenreId { get; set;}
        public Genre Genre { get; set; } = null!;
    }
}
