using MoviesWatchlist.Web.ViewModels.Genre;
using MoviesWatchlist.Web.ViewModels.MovieParticipants;
using System.ComponentModel.DataAnnotations;

namespace MoviesWatchlist.Web.ViewModels.Movie
{
    using static Common.EntityValidationConstants.Movie;

    public class AddMovieViewModel
    {
        public AddMovieViewModel()
        {
            WritersIds = new HashSet<string>();
            ActorsIds = new HashSet<string>();
            GenresIds = new HashSet<string>();
            Directors = new HashSet<SelectParticipantFormModel>();
            Writers = new HashSet<SelectParticipantFormModel>();
            Actors = new HashSet<SelectParticipantFormModel>();
            Genres = new HashSet<SelectGenreFormModel>();
        }

        [Required]
        [StringLength(TitleMaxLength, MinimumLength = TitleMinLength)]
        public string Title { get; set; } = null!;

        [Required]
        [Range(ReleaseYearMinValue, ReleaseYearMaxValue)]
        public int ReleaseYear { get; set; }

        [Required]
        [Range(RatingMinValue, RatingMaxValue)]
        public decimal Rating { get; set; }

        [Required]
        [StringLength(DescriptionMaxLength, MinimumLength = DescriptionMinLength)]
        public string Description { get; set; } = null!;

        [Required]
        [StringLength(ImageURLMaxLength, MinimumLength = ImageURLMinLength)]
        public string ImgURL { get; set; } = null!;

        [Required]
        [Display(Name = "Director")]
        public string DirectorId { get; set; } = null!;

        public IEnumerable<SelectParticipantFormModel> Directors { get; set; }

        [Display(Name = "Writers")]
        public ICollection<string> WritersIds { get; set; }

        public IEnumerable<SelectParticipantFormModel> Writers { get; set; }

        [Display(Name = "Actors")]
        public ICollection<string> ActorsIds { get; set; }

        public IEnumerable<SelectParticipantFormModel> Actors { get; set; }

        public ICollection<string> GenresIds { get; set; }

        public IEnumerable<SelectGenreFormModel> Genres { get; set; }
    }
}
