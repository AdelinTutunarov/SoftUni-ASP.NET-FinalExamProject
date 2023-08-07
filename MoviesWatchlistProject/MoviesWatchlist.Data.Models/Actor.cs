using System.ComponentModel.DataAnnotations;

namespace MoviesWatchlist.Data.Models
{
    using static Common.EntityValidationConstants.Person;

    public class Actor
    {
        public Actor()
        {
            Id = Guid.NewGuid();
            MoviesActors = new HashSet<MovieActor>();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(FirstNameMaxLength)]
        public string FirstName { get; set; } = null!;

        [Required]
        [MaxLength(LastNameMaxLength)]
        public string LastName { get; set; } = null!;

        [Required]
        [MaxLength(ImageURLMaxLength)]
        public string ImageURL { get; set; } = null!;

        [Required]
        [MaxLength(NationalityMaxLength)]
        public string Nationality { get; set; } = null!;

        public ICollection<MovieActor> MoviesActors { get; set; }
    }
}
