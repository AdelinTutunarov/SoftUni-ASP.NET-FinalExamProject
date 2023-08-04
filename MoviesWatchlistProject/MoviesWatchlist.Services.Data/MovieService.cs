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
            string[] existingActorIds = dbContext.Actors.Select(a => a.Id.ToString()).ToArray();
            string[] existingWriterIds = dbContext.Writers.Select(w => w.Id.ToString()).ToArray();
            string[] existingGenreIds = dbContext.Genres.Select(g => g.Id.ToString()).ToArray();

            Movie movie = new Movie()
			{
				Id = id,
				Title = model.Title,
				ReleaseYear = model.ReleaseYear,
				Rating = model.Rating,
				Description = model.Description,
				ImageURL = model.ImgURL,
				DirectorId = Guid.Parse(model.DirectorId)
			};

            foreach (var actor in model.Actors)
            {
                if (existingActorIds.Contains(actor.Id))
                {
                    MovieActor movieActor = new MovieActor()
                    {
                        ActorId = Guid.Parse(actor.Id),
                        MovieId = id
                    };
                    movie.MoviesActors.Add(movieActor);
                }
            }

            foreach (var writer in model.Writers)
            {
                if (existingWriterIds.Contains(writer.Id))
                {
                    MovieWriter movieWriter = new MovieWriter()
                    {
                        WriterId = Guid.Parse(writer.Id),
                        MovieId = id
                    };
                    movie.MoviesWriters.Add(movieWriter);
                }
            }

            foreach (var genre in model.Genres)
            {
                if (existingGenreIds.Contains(genre.Id))
                {
                    MovieGenre movieGenre = new MovieGenre()
                    {
                        GenreId = Guid.Parse(genre.Id),
                        MovieId = id
                    };
                    movie.MoviesGenres.Add(movieGenre);
                }
            }

            await dbContext.AddAsync(movie);
			await dbContext.SaveChangesAsync();
        }
    }
}
