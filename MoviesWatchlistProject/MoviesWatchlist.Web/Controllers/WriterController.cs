using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MoviesWatchlist.Services.Data.Interfaces;
using MoviesWatchlist.Services.Data.Models.MovieParticipants;
using MoviesWatchlist.Web.ViewModels.MovieParticipants;

namespace MoviesWatchlist.Web.Controllers
{
    [Authorize]
    public class WriterController : BaseController
    {
        private readonly IWriterService writerService;

        public WriterController(IWriterService writerService)
        {
            this.writerService = writerService;
        }

        [AllowAnonymous]
        public async Task<IActionResult> All([FromQuery]AllParticipantQueryModel queryModel)
        {
            AllParticipantServiceModel serviceModel = await writerService.AllAsync(queryModel);

            queryModel.Participants = serviceModel.Participants;
            queryModel.TotalParticipants = serviceModel.TotalParticipantsCount;

            return View(queryModel);
        }
    }
}
