using MoviesWatchlist.Web.ViewModels.MovieParticipants;

namespace MoviesWatchlist.Services.Data.Models.MovieParticipants
{
    public class AllParticipantServiceModel
    {
        public AllParticipantServiceModel()
        {
            Participants = new HashSet<AllParticipantViewModel>();
        }

        public int TotalParticipantsCount { get; set; }

        public IEnumerable<AllParticipantViewModel> Participants { get; set; }
    }
}
