using Microsoft.EntityFrameworkCore;
using MoviesWatchlist.Data;
using MoviesWatchlist.Data.Models;
using MoviesWatchlist.Services.Data.Interfaces;
using MoviesWatchlist.Services.Data.Models.MovieParticipants;
using MoviesWatchlist.Web.ViewModels.MovieParticipants;

namespace MoviesWatchlist.Services.Data
{
    public class WriterService : IWriterService
    {
        private readonly MoviesDbContext dbContext;

        public WriterService(MoviesDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<AllParticipantServiceModel> AllAsync(AllParticipantQueryModel queryModel)
        {
            IQueryable<Writer> writersQuery = dbContext.Writers.AsQueryable();

            if (!string.IsNullOrWhiteSpace(queryModel.FullName))
            {
                string wildCard = $"%{queryModel.FullName.ToLower()}%";

                writersQuery = writersQuery.Where(w => EF.Functions.Like($"{w.FirstName} {w.LastName}", wildCard));
            }

            IEnumerable<AllParticipantViewModel> writers = await writersQuery
                .Skip((queryModel.CurrentPage - 1) * queryModel.ParticipantsPerPage)
                .Take(queryModel.ParticipantsPerPage)
                .Select(w => new AllParticipantViewModel()
                {
                    Id = w.Id.ToString(),
                    FullName = $"{w.FirstName} {w.LastName}",
                    Nationality = w.Nationality,
                    ImageURL = w.ImageURL
                }).ToArrayAsync();

            int totalWriters = writersQuery.Count();

            return new AllParticipantServiceModel()
            {
                TotalParticipantsCount = totalWriters,
                Participants = writers
            };
        }

        public async Task<IEnumerable<SelectParticipantFormModel>> AllWritersAsync()
        {
            IEnumerable<SelectParticipantFormModel> allWriters = await dbContext
                .Writers
                .AsNoTracking()
                .Select(w => new SelectParticipantFormModel
                {
                    Id = w.Id.ToString(),
                    FullName = w.FirstName + " " + w.LastName
                }).ToListAsync();

            return allWriters;
        }

        public async Task<bool> ExistsByIdAsync(string id)
        {
            bool result = await dbContext.Writers.AnyAsync(w => w.Id.ToString() == id);

            return result;
        }
    }
}
