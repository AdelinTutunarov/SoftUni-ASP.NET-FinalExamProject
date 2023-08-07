using System.ComponentModel.DataAnnotations;

namespace MoviesWatchlist.Web.ViewModels.MovieParticipants
{
    public class AllParticipantViewModel
    {
        public string Id { get; set; } = null!;

        [Display(Name = "Full Name")]
        public string FullName { get; set; } = null!;

        [Display(Name = "Image Link")]
        public string ImageURL { get; set; } = null!;

        public string Nationality { get; set; } = null!;
    }
}
