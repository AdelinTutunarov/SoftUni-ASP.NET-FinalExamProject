using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MoviesWatchlist.Services.Data.Interfaces;
using MoviesWatchlist.Services.Data.Models.Genre;
using MoviesWatchlist.Web.ViewModels.Genre;

namespace MoviesWatchlist.Web.Controllers
{
    [Authorize]
    public class GenreController : Controller
    {
        private readonly IGenreService genreService;

        public GenreController(IGenreService genreService)
        {
            this.genreService = genreService;
        }

        [AllowAnonymous]
        public async Task<IActionResult> All([FromQuery]AllGenreQueryModel queryModel)
        {
            AllGenreServiceModel serviceModel = await genreService.AllAsync(queryModel);

            queryModel.Genres = serviceModel.Genres;
            queryModel.TotalGenres = serviceModel.TotalGenresCount;

            return View(queryModel);
        }
    }
}
