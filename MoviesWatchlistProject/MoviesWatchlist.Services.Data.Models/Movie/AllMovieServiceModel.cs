using MoviesWatchlist.Web.ViewModels.Movie;

namespace MoviesWatchlist.Services.Data.Models.Movie
{
    public class AllMovieServiceModel
    {
        public AllMovieServiceModel()
        {
            Movies = new HashSet<AllMovieViewModel>();
        }

        public int TotalMoviesCount { get; set; }

        public IEnumerable<AllMovieViewModel> Movies { get; set; }
    }
}
