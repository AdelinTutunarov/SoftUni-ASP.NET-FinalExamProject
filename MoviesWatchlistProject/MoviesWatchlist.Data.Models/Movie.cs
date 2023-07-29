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
        public Guid Id { get; set; }

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
        public Guid DirectorId { get; set; }
        public Director Director { get; set; } = null!;

        public ICollection<MovieActor> MoviesActors { get; set; }

        public ICollection<MovieGenre> MoviesGenres { get; set; }

        public ICollection<MovieWriter> MoviesWriters { get; set; }

        public ICollection<IdentityUserMovie> IdentityUsersMovies { get; set; }
    }
}
