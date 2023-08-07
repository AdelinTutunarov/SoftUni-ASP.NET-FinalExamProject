using MoviesWatchlist.Services.Data.Models.MovieParticipants;
using MoviesWatchlist.Web.ViewModels.MovieParticipants;

namespace MoviesWatchlist.Services.Data.Interfaces
{
    public interface IDirectorService
    {
        Task<IEnumerable<SelectParticipantFormModel>> AllDirectorsAsync();

        Task<bool> ExistsByIdAsync(string id);

        Task<AllParticipantServiceModel> AllAsync(AllParticipantQueryModel queryModel);
    }
}
