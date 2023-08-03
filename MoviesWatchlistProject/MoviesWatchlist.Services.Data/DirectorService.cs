using Microsoft.EntityFrameworkCore;
using MoviesWatchlist.Data;
using MoviesWatchlist.Services.Data.Interfaces;
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
