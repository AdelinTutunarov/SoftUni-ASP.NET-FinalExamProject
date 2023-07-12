using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesWatchlist.Data.Models
{
    using static Common.EntityValidationConstants.Movie;

    public class Movie
    {
        public Movie()
        {
            MoviesActors = new HashSet<MovieActor>();
            MoviesGenres = new HashSet<MovieGenre>();
            MoviesWriters = new HashSet<MovieWriter>();
            IdentityUsersMovies = new HashSet<IdentityUserMovie>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(TitleMaxLength)]
        public string Title { get; set; } = null!;

        [Required]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;

        [Required]
        public int ReleaseYear { get; set; }

        [Required]
        public decimal Rating { get; set; }

        [Required]
        [MaxLength(ImageURLMaxLength)]
        public string ImageURL { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Director))]
        public int DirectorId { get; set; }
        public Director Director { get; set; } = null!;

        public IEnumerable<MovieActor> MoviesActors { get; set; }

        public IEnumerable<MovieGenre> MoviesGenres { get; set; }

        public IEnumerable<MovieWriter> MoviesWriters { get; set; }

        public IEnumerable<IdentityUserMovie> IdentityUsersMovies { get; set; }
    }
}
