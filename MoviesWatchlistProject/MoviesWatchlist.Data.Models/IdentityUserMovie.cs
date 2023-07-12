using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesWatchlist.Data.Models
{
    public class IdentityUserMovie
    {
        [Required]
        [ForeignKey(nameof(Collector))]
        public string CollectorId { get; set; } = null!;
        public IdentityUser Collector { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Movie))]
        public int MovieId { get; set; }
        public Movie Movie { get; set; } = null!;
    }
}
