using MoviesWatchlist.Data;
using MoviesWatchlist.Services.Data.Interfaces;

namespace MoviesWatchlist.Services.Data
{
	public class MovieService : IMovieService
	{
		private readonly MoviesDbContext dbContext;

		public MovieService(MoviesDbContext dbContext)
		{
			this.dbContext = dbContext;
		}
	}
}
