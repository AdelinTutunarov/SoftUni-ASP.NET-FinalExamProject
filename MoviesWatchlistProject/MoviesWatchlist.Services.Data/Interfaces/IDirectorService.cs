using MoviesWatchlist.Web.ViewModels.MovieParticipants;

namespace MoviesWatchlist.Services.Data.Interfaces
{
    public interface IDirectorService
    {
        Task<IEnumerable<SelectParticipantFormModel>> AllDirectorsAsync();
    }
}
