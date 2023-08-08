using MoviesWatchlist.Services.Data.Models.Movie;
using MoviesWatchlist.Web.ViewModels.Movie;

namespace MoviesWatchlist.Services.Data.Interfaces
{
	public interface IMovieService
	{
        Task<bool> ExistsByIdAsync(string id);

        Task AddMovieAsync(AddMovieViewModel model);

		Task<AllMovieServiceModel> AllAsync(AllMovieQueryModel queryModel);

		Task<IEnumerable<AllMovieViewModel>> GetMyMoviesAsync(string userId);

		Task<DetailsMovieViewModel> GetMovieDetailsAsync(string movieId);
    }
}
