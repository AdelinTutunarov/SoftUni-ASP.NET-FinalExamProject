using MoviesWatchlist.Web.ViewModels.MovieParticipants;

namespace MoviesWatchlist.Services.Data.Interfaces
{
    public interface IActorService
    {
        Task<IEnumerable<SelectParticipantFormModel>> AllActorsAsync();

        Task<bool> ExistsByIdAsync(string id);
    }
}
