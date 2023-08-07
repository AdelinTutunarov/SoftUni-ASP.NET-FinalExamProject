using MoviesWatchlist.Services.Data.Models.MovieParticipants;
using MoviesWatchlist.Web.ViewModels.MovieParticipants;

namespace MoviesWatchlist.Services.Data.Interfaces
{
    public interface IWriterService
    {
        Task<IEnumerable<SelectParticipantFormModel>> AllWritersAsync();

        Task<bool> ExistsByIdAsync(string id);

        Task<AllParticipantServiceModel> AllAsync(AllParticipantQueryModel queryModel);
    }
}
