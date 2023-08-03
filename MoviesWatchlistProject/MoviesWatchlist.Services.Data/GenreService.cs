using Microsoft.EntityFrameworkCore;
using MoviesWatchlist.Data;
using MoviesWatchlist.Services.Data.Interfaces;
using MoviesWatchlist.Web.ViewModels.Genre;

namespace MoviesWatchlist.Services.Data
{
    public class GenreService : IGenreService
    {
        private readonly MoviesDbContext dbContext;

        public GenreService(MoviesDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<SelectGenreFormModel>> AllGenresAsync()
        {
            IEnumerable<SelectGenreFormModel> allGenres = await dbContext
                .Genres
                .AsNoTracking()
                .Select(g => new SelectGenreFormModel
                {
                    Id = g.Id.ToString(),
                    Name = g.Name,
                }).ToListAsync();

            return allGenres;
        }

        public async Task<bool> ExistsByIdAsync(string id)
        {
            bool result = await dbContext.Genres.AnyAsync(g => g.Id.ToString() == id);

            return result;
        }
    }
}
