using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MoviesWatchlist.Services.Data.Interfaces;
using MoviesWatchlist.Web.ViewModels.Movie;

namespace MoviesWatchlist.Web.Controllers
{
	[Authorize]
	public class MovieController : Controller
	{
		private readonly IActorService actorService;
		private readonly IDirectorService directorService;
		private readonly IGenreService genreService;
		private readonly IWriterService writerService;
		private readonly IMovieService movieService;

		public MovieController(IActorService actorService, IDirectorService directorService,
			IGenreService genreService, IWriterService writerService, IMovieService movieService)
		{
			this.actorService = actorService;
			this.directorService = directorService;
			this.genreService = genreService;
			this.writerService = writerService;
			this.movieService = movieService;
		}

		[AllowAnonymous]
		public async Task<IActionResult> All()
		{
			return View();
		}

		[HttpGet]
		public async Task<IActionResult> Add()
		{
			AddMovieViewModel movieViewModel = new AddMovieViewModel()
			{
				Directors = await directorService.AllDirectorsAsync(),
				Writers = await writerService.AllWritersAsync(),
				Actors = await actorService.AllActorsAsync(),
				Genres = await genreService.AllGenresAsync()
			};

			return View(movieViewModel);
		}
	}
}
