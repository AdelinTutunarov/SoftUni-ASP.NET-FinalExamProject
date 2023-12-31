﻿using MoviesWatchlist.Services.Data.Models.Genre;
using MoviesWatchlist.Web.ViewModels.Genre;

namespace MoviesWatchlist.Services.Data.Interfaces
{
    public interface IGenreService
    {
        Task<IEnumerable<SelectGenreFormModel>> AllGenresAsync();

        Task<bool> ExistsByIdAsync(string id);

        Task<AllGenreServiceModel> AllAsync(AllGenreQueryModel queryModel);
    }
}
