using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MoviesWatchlist.Services.Data.Interfaces;
using MoviesWatchlist.Services.Data.Models.Movie;
using MoviesWatchlist.Web.ViewModels.Movie;

namespace MoviesWatchlist.Web.Controllers
{
    using static Common.NotificationMessagesConstants;

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

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> All([FromQuery]AllMovieQueryModel queryModel)
        {
            AllMovieServiceModel serviceModel = await movieService.AllAsync(queryModel);

            queryModel.Movies = serviceModel.Movies;
            queryModel.TotalMovies = serviceModel.TotalMoviesCount;
            
            return View(queryModel);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            try
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
            catch (Exception)
            {
                return GeneralError();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddMovieViewModel model)
        {
            bool directorExists, writersExist = false, actorsExist = false, genresExist = false;

            directorExists = await directorService.ExistsByIdAsync(model.DirectorId);

            if (!directorExists)
            {
                ModelState.AddModelError(nameof(model.DirectorId), "Selected director does not exists!");
            }

            foreach (var writer in model.Writers)
            {
                writersExist = await writerService.ExistsByIdAsync(writer.Id);

                if (!writersExist)
                {
                    ModelState.AddModelError(nameof(writer.Id), "Selected writer dos not exists!");
                    break;
                }
            }

            foreach (var actor in model.Actors)
            {
                actorsExist = await actorService.ExistsByIdAsync(actor.Id);

                if (!actorsExist)
                {
                    ModelState.AddModelError(nameof(actor.Id), "Selected actor does not exists!");
                    break;
                }
            }

            foreach (var genre in model.Genres)
            {
                genresExist = await genreService.ExistsByIdAsync(genre.Id);

                if (!genresExist)
                {
                    ModelState.AddModelError(nameof(genre.Id), "Selected genre does not exists!");
                    break;
                }
            }

            if (!ModelState.IsValid)
            {
                model.Actors = await actorService.AllActorsAsync();
                model.Directors = await directorService.AllDirectorsAsync();
                model.Writers = await writerService.AllWritersAsync();
                model.Genres = await genreService.AllGenresAsync();

                return View(model);
            }

            try
            {
                await movieService.AddMovieAsync(model);

                TempData[SuccessMessage] = "House was added successfully!";
                return RedirectToAction("All", "Movie");
            }
            catch(Exception)
            {
                ModelState.AddModelError(string.Empty, "Unexpected error occurred while trying to add your new house! Please try again later or contact administrator!");

                model.Actors = await actorService.AllActorsAsync();
                model.Directors = await directorService.AllDirectorsAsync();
                model.Writers = await writerService.AllWritersAsync();
                model.Genres = await genreService.AllGenresAsync();

                return View(model);
            }

        }

        private IActionResult GeneralError()
        {
            TempData[ErrorMessage] =
                "Unexpected error occurred! Please try again later or contact administrator";

            return RedirectToAction("Index", "Home");
        }
    }
}
