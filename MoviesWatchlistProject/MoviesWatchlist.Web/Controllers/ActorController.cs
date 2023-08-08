using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MoviesWatchlist.Services.Data.Interfaces;
using MoviesWatchlist.Services.Data.Models.MovieParticipants;
using MoviesWatchlist.Web.ViewModels.MovieParticipants;

namespace MoviesWatchlist.Web.Controllers
{
    [Authorize]
    public class ActorController : Controller
    {
        private readonly IActorService actorService;

        public ActorController(IActorService actorService)
        {
            this.actorService = actorService;
        }

        [AllowAnonymous]
        public async Task<IActionResult> All([FromQuery]AllParticipantQueryModel queryModel)
        {
            AllParticipantServiceModel serviceModel = await actorService.AllAsync(queryModel);

            queryModel.Participants = serviceModel.Participants;
            queryModel.TotalParticipants = serviceModel.TotalParticipantsCount;

            return View(queryModel);
        }
    }
}
