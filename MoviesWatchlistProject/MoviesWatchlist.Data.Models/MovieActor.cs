using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesWatchlist.Data.Models
{
    public class MovieActor
    {
        [Required]
        [ForeignKey(nameof(Movie))]
        public Guid MovieId { get; set; }
        public Movie Movie { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Actor))]
        public Guid ActorId { get; set; }
        public Actor Actor { get; set; } = null!;
    }
}
