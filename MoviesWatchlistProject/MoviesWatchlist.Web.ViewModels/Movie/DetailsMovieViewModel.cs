using MoviesWatchlist.Web.ViewModels.Genre;
using MoviesWatchlist.Web.ViewModels.MovieParticipants;

namespace MoviesWatchlist.Web.ViewModels.Movie
{
    public class DetailsMovieViewModel : AllMovieViewModel
    {
        public DetailsMovieViewModel()
        {
            Actors = new HashSet<SelectParticipantFormModel>();
            Writers = new HashSet<SelectParticipantFormModel>();
            Genres = new HashSet<SelectGenreFormModel>();
        }

        public string Description { get; set; } = null!;

        public IEnumerable<SelectGenreFormModel> Genres { get; set; }

        public SelectParticipantFormModel Director { get; set; } = null!;

        public IEnumerable<SelectParticipantFormModel> Writers { get; set; }

        public IEnumerable<SelectParticipantFormModel> Actors { get; set; }
    }
}
