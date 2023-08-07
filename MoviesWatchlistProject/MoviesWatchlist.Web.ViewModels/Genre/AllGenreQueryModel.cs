using System.ComponentModel.DataAnnotations;

namespace MoviesWatchlist.Web.ViewModels.Genre
{
    using static Common.GeneralAppConstants;

    public class AllGenreQueryModel
    {
        public AllGenreQueryModel()
        {
            CurrentPage = DefaultPage;
            GenresPerPage = EntitiesPerPage;

            Genres = new HashSet<AllGenreViewModel>();
        }

        [Display(Name = "Genre:")]
        public string? GenreName { get; set; }

        public int CurrentPage { get; set; }

        public int GenresPerPage { get; set; }

        public int TotalGenres { get; set; }

        public IEnumerable<AllGenreViewModel> Genres { get; set; }
    }
}
