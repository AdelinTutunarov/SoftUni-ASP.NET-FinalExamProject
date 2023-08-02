using MoviesWatchlist.Web.ViewModels.Genre;

namespace MoviesWatchlist.Services.Data.Interfaces
{
    public interface IGenreService
    {
        Task<IEnumerable<SelectGenreFormModel>> AllGenresAsync();
    }
}
