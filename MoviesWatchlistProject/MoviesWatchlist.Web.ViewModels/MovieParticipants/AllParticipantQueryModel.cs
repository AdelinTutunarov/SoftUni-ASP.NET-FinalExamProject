using System.ComponentModel.DataAnnotations;

namespace MoviesWatchlist.Web.ViewModels.MovieParticipants
{
    using static Common.GeneralAppConstants;

    public class AllParticipantQueryModel
    {

        public AllParticipantQueryModel()
        {
            CurrentPage = DefaultPage;
            ParticipantsPerPage = EntitiesPerPage;

            Participants = new HashSet<AllParticipantViewModel>();
        }

        [Display(Name = "Search name:")]
        public string? FullName { get; set; }

        public int CurrentPage { get; set; }

        public int ParticipantsPerPage { get; set; }

        public int TotalParticipants { get; set; }

        public IEnumerable<AllParticipantViewModel> Participants { get; set; }
    }
}
