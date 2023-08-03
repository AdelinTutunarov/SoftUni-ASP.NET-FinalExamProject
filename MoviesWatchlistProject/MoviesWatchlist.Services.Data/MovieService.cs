using MoviesWatchlist.Data;
using MoviesWatchlist.Data.Models;
using MoviesWatchlist.Services.Data.Interfaces;
using MoviesWatchlist.Web.ViewModels.Movie;

namespace MoviesWatchlist.Services.Data
{
	public class MovieService : IMovieService
	{
		private readonly MoviesDbContext dbContext;

		public MovieService(MoviesDbContext dbContext)
		{
			this.dbContext = dbContext;
		}

        public async Task AddMovieAsync(AddMovieViewModel model)
        {
			Guid id = Guid.NewGuid();
			ICollection<MovieActor> movieActors = new HashSet<MovieActor>();
			ICollection<MovieWriter> movieWriters = new HashSet<MovieWriter>();
			ICollection<MovieGenre> movieGenres = new HashSet<MovieGenre>();

			foreach (var actor in model.Actors)
			{
				MovieActor movieActor = new MovieActor()
				{
					ActorId = Guid.Parse(actor.Id),
					MovieId = id
				};
				movieActors.Add(movieActor);
			}

			foreach (var writer in model.Writers)
			{
				MovieWriter movieWriter = new MovieWriter()
				{
					WriterId = Guid.Parse(writer.Id),
					MovieId = id
				};
				movieWriters.Add(movieWriter);
			}

			foreach (var genre in model.Genres)
			{
				MovieGenre movieGenre = new MovieGenre()
				{
					GenreId = Guid.Parse(genre.Id),
					MovieId = id
				};
			}

            Movie movie = new Movie()
			{
				Id = id,
				Title = model.Title,
				ReleaseYear = model.ReleaseYear,
				Rating = model.Rating,
				Description = model.Description,
				ImageURL = model.ImgURL,
				DirectorId = Guid.Parse(model.DirectorId),
				MoviesActors = movieActors,
				MoviesWriters = movieWriters,
				MoviesGenres = movieGenres
			};

			await dbContext.AddAsync(movie);
			await dbContext.SaveChangesAsync();
        }
    }
}
