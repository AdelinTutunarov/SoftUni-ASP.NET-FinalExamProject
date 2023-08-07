using System.ComponentModel.DataAnnotations;

namespace MoviesWatchlist.Data.Models
{
    using static Common.EntityValidationConstants.Genre;

    public class Genre
    {
        public Genre()
        {
            Id = Guid.NewGuid();
            MoviesGenres = new HashSet<MovieGenre>();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(ImageURLMaxLength)]
        public string ImageURL { get; set; } = null!;

        public ICollection<MovieGenre> MoviesGenres { get; set; }
    }
}