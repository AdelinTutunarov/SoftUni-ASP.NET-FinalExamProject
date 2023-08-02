using Microsoft.EntityFrameworkCore;
using MoviesWatchlist.Data;
using MoviesWatchlist.Services.Data.Interfaces;
using MoviesWatchlist.Web.ViewModels.MovieParticipants;

namespace MoviesWatchlist.Services.Data
{
    public class ActorService : IActorService
    {
        private readonly MoviesDbContext dbContext;

        public ActorService(MoviesDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<SelectParticipantFormModel>> AllActorsAsync()
        {
            IEnumerable<SelectParticipantFormModel> allActors = await dbContext
                .Actors
                .AsNoTracking()
                .Select(a => new SelectParticipantFormModel
                {
                    Id = a.Id.ToString(),
                    FullName = a.FirstName + " " + a.LastName,
                }).ToArrayAsync();

            return allActors;
        }
    }
}
