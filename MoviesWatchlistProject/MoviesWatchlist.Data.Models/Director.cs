using System.ComponentModel.DataAnnotations;

namespace MoviesWatchlist.Data.Models
{
    using static Common.EntityValidationConstants.Person;

    public class Director
    {
        public Director()
        {
            Movies = new HashSet<Movie>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(FirstNameMaxLength)]
        public string FirstName { get; set; } = null!;

        [Required]
        [MaxLength(LastNameMaxLength)]
        public string LastName { get; set; } = null!;

        [Required]
        [MaxLength(NationalityMaxLength)]
        public string Nationality { get; set; } = null!;

        public IEnumerable<Movie> Movies { get; set; }
    }
}
