using Microsoft.EntityFrameworkCore;
using MoviesWatchlist.Data;
using MoviesWatchlist.Data.Models;
using MoviesWatchlist.Services.Data.Interfaces;
using MoviesWatchlist.Services.Data.Models.Genre;
using MoviesWatchlist.Web.ViewModels.Genre;
using MoviesWatchlist.Web.ViewModels.MovieParticipants;

namespace MoviesWatchlist.Services.Data
{
    public class GenreService : IGenreService
    {
        private readonly MoviesDbContext dbContext;

        public GenreService(MoviesDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<AllGenreServiceModel> AllAsync(AllGenreQueryModel queryModel)
        {
            IQueryable<Genre> genresQuery = dbContext.Genres.AsQueryable();

            if (!string.IsNullOrWhiteSpace(queryModel.GenreName))
            {
                string wildCard = $"%{queryModel.GenreName.ToLower()}%";

                genresQuery = genresQuery.Where(w => EF.Functions.Like(w.Name, wildCard));
            }

            IEnumerable<AllGenreViewModel> genres = await genresQuery
                .Skip((queryModel.CurrentPage - 1) * queryModel.GenresPerPage)
                .Take(queryModel.GenresPerPage)
                .Select(g => new AllGenreViewModel()
                {
                    Id = g.Id.ToString(),
                    GenreName = g.Name,
                    ImgURL = g.ImageURL
                }).ToArrayAsync();

            int totalGenres = genresQuery.Count();

            return new AllGenreServiceModel()
            {
                TotalGenresCount = totalGenres,
                Genres = genres
            };
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
