using MoviesWatchlist.Services.Data.Models.Movie;
using MoviesWatchlist.Web.ViewModels.Movie;

namespace MoviesWatchlist.Services.Data.Interfaces
{
	public interface IMovieService
	{
		Task AddMovieAsync(AddMovieViewModel model);

		Task<AllMovieServiceModel> AllAsync(AllMovieQueryModel queryModel);
    }
}
