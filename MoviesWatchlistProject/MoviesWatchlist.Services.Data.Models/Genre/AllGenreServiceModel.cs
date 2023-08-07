using MoviesWatchlist.Web.ViewModels.Genre;

namespace MoviesWatchlist.Services.Data.Models.Genre
{
    public class AllGenreServiceModel
    {
        public AllGenreServiceModel()
        {
            Genres = new HashSet<AllGenreViewModel>();
        }

        public int TotalGenresCount { get; set; }

        public IEnumerable<AllGenreViewModel> Genres { get; set; }
    }
}
