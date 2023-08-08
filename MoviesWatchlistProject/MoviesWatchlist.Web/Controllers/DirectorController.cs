using Microsoft.AspNetCore.Mvc;
using MoviesWatchlist.Services.Data.Interfaces;
using MoviesWatchlist.Services.Data.Models.MovieParticipants;
using MoviesWatchlist.Web.ViewModels.MovieParticipants;

namespace MoviesWatchlist.Web.Controllers
{
    public class DirectorController : Controller
    {
        private readonly IDirectorService directorService;

        public DirectorController(IDirectorService directorService)
        {
            this.directorService = directorService;
        }

        public async Task<IActionResult> All([FromQuery]AllParticipantQueryModel queryModel)
        {
            AllParticipantServiceModel serviceModel = await directorService.AllAsync(queryModel);

            queryModel.Participants = serviceModel.Participants;
            queryModel.TotalParticipants = serviceModel.TotalParticipantsCount;

            return View(queryModel);
        }
    }
}
