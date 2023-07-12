using System.ComponentModel.DataAnnotations;

namespace MoviesWatchlist.Data.Models
{
    using static Common.EntityValidationConstants.Genre;

    public class Genre
    {
        public Genre()
        {
            MoviesGenres = new HashSet<MovieGenre>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        public IEnumerable<MovieGenre> MoviesGenres { get; set; }
    }
}