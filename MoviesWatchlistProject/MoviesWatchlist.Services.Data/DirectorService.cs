using Microsoft.EntityFrameworkCore;
using MoviesWatchlist.Data;
using MoviesWatchlist.Data.Models;
using MoviesWatchlist.Services.Data.Interfaces;
using MoviesWatchlist.Services.Data.Models.MovieParticipants;
using MoviesWatchlist.Web.ViewModels.MovieParticipants;

namespace MoviesWatchlist.Services.Data
{
    public class DirectorService : IDirectorService
    {
        private readonly MoviesDbContext dbContext;

        public DirectorService(MoviesDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<AllParticipantServiceModel> AllAsync(AllParticipantQueryModel queryModel)
        {
            IQueryable<Director> directorsQuery = dbContext.Directors.AsQueryable();

            if (!string.IsNullOrWhiteSpace(queryModel.FullName))
            {
                string wildCard = $"%{queryModel.FullName.ToLower()}%";

                directorsQuery = directorsQuery.Where(d => EF.Functions.Like($"{d.FirstName} {d.LastName}", wildCard));
            }

            IEnumerable<AllParticipantViewModel> directors = await directorsQuery
                .Skip((queryModel.CurrentPage - 1) * queryModel.ParticipantsPerPage)
                .Take(queryModel.ParticipantsPerPage)
                .Select(d => new AllParticipantViewModel()
                {
                    Id = d.Id.ToString(),
                    FullName = $"{d.FirstName} {d.LastName}",
                    Nationality = d.Nationality,
                    ImageURL = d.ImageURL
                }).ToArrayAsync();

            int totalDirectors = directorsQuery.Count();

            return new AllParticipantServiceModel()
            {
                TotalParticipantsCount = totalDirectors,
                Participants = directors
            };
        }

        public async Task<IEnumerable<SelectParticipantFormModel>> AllDirectorsAsync()
        {
            IEnumerable<SelectParticipantFormModel> allDirectors = await dbContext
                .Directors
                .AsNoTracking()
                .Select(d => new SelectParticipantFormModel
                {
                    Id = d.Id.ToString(),
                    FullName = d.FirstName + " " + d.LastName
                }).ToListAsync();

            return allDirectors;
        }

        public  async Task<bool> ExistsByIdAsync(string id)
        {
            bool result = await dbContext.Directors.AnyAsync(d => d.Id.ToString() == id);

            return result;
        }
    }
}
