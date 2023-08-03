using MoviesWatchlist.Web.ViewModels.Movie;

namespace MoviesWatchlist.Services.Data.Interfaces
{
	public interface IMovieService
	{
		Task AddMovieAsync(AddMovieViewModel model);

    }
}
