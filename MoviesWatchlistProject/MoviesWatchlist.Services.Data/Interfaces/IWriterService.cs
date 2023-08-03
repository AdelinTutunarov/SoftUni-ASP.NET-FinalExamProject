using MoviesWatchlist.Web.ViewModels.MovieParticipants;

namespace MoviesWatchlist.Services.Data.Interfaces
{
    public interface IWriterService
    {
        Task<IEnumerable<SelectParticipantFormModel>> AllWritersAsync();

        Task<bool> ExistsByIdAsync(string id);
    }
}
