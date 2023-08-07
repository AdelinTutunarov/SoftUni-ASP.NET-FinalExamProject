using Microsoft.EntityFrameworkCore;
using MoviesWatchlist.Data;
using MoviesWatchlist.Data.Models;
using MoviesWatchlist.Services.Data.Interfaces;
using MoviesWatchlist.Services.Data.Models.Movie;
using MoviesWatchlist.Web.ViewModels.Movie;
using MoviesWatchlist.Web.ViewModels.Movie.Enums;

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

        public async Task<AllMovieServiceModel> AllAsync(AllMovieQueryModel queryModel)
        {
            IQueryable<Movie> moviesQuery = dbContext.Movies.AsQueryable();

            if (!string.IsNullOrWhiteSpace(queryModel.Title))
            {
                string wildCard = $"%{queryModel.Title.ToLower()}%";

                moviesQuery = moviesQuery.Where(m => EF.Functions.Like(m.Title, wildCard));
            }

            moviesQuery = queryModel.MovieSorting switch
            {
                MovieSorting.ReleaseYearNewest => moviesQuery.OrderBy(m => m.ReleaseYear),
                MovieSorting.ReleaseYearOldest => moviesQuery.OrderByDescending(m => m.ReleaseYear),
                MovieSorting.RatingAscending => moviesQuery.OrderBy(m => m.Rating),
                MovieSorting.RatingDescending => moviesQuery.OrderByDescending(m => m.Rating),
                _ => moviesQuery.OrderBy(m => m.Id)
            };

            IEnumerable<AllMovieViewModel> movies = await moviesQuery
                .Skip((queryModel.CurrentPage - 1) * queryModel.MoviesPerPage)
                .Take(queryModel.MoviesPerPage)
                .Select(m => new AllMovieViewModel()
                {
                    Id = m.Id.ToString(),
                    Title = m.Title,
                    ReleaseYear = m.ReleaseYear,
                    Rating = m.Rating,
                    ImgURL = m.ImageURL
                }).ToArrayAsync();

            int totalMovies = moviesQuery.Count();

            return new AllMovieServiceModel()
            {
                TotalMoviesCount = totalMovies,
                Movies = movies
            };
        }
    }
}
