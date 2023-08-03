using Microsoft.EntityFrameworkCore;
using MoviesWatchlist.Data;
using MoviesWatchlist.Services.Data.Interfaces;
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
