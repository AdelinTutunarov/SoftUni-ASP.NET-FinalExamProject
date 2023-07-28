using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesWatchlist.Data.Models
{
    public class IdentityUserMovie
    {
        [Required]
        [ForeignKey(nameof(Collector))]
        public Guid CollectorId { get; set; }
        public AppUser Collector { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Movie))]
        public Guid MovieId { get; set; }
        public Movie Movie { get; set; } = null!;
    }
}
