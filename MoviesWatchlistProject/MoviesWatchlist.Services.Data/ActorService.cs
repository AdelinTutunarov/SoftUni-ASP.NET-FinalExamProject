using Microsoft.EntityFrameworkCore;
using MoviesWatchlist.Data;
using MoviesWatchlist.Data.Models;
using MoviesWatchlist.Services.Data.Interfaces;
using MoviesWatchlist.Services.Data.Models.MovieParticipants;
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

        public async Task<AllParticipantServiceModel> AllAsync(AllParticipantQueryModel queryModel)
        {
            IQueryable<Actor> actorsQuery = dbContext.Actors.AsQueryable();

            if (!string.IsNullOrWhiteSpace(queryModel.FullName))
            {
                string wildCard = $"%{queryModel.FullName.ToLower()}%";

                actorsQuery = actorsQuery.Where(a => EF.Functions.Like($"{a.FirstName} {a.LastName}", wildCard));
            }

            IEnumerable<AllParticipantViewModel> actors = await actorsQuery
                .Skip((queryModel.CurrentPage - 1) * queryModel.ParticipantsPerPage)
                .Take(queryModel.ParticipantsPerPage)
                .Select(a => new AllParticipantViewModel()
                {
                    Id = a.Id.ToString(),
                    FullName = $"{a.FirstName} {a.LastName}",
                    Nationality = a.Nationality,
                    ImageURL = a.ImageURL
                }).ToArrayAsync();

            int totalActors = actorsQuery.Count();

            return new AllParticipantServiceModel()
            {
                TotalParticipantsCount = totalActors,
                Participants = actors
            };
        }

        public async Task<bool> ExistsByIdAsync(string id)
        {
            bool result = await dbContext.Actors.AnyAsync(a => a.Id.ToString() == id);

            return result;
        }
    }
}
