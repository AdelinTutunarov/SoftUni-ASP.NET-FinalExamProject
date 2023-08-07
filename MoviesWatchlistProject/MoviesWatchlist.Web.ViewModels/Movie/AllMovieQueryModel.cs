using MoviesWatchlist.Web.ViewModels.Movie.Enums;
using System.ComponentModel.DataAnnotations;

namespace MoviesWatchlist.Web.ViewModels.Movie
{
    using static Common.GeneralAppConstants;

    public class AllMovieQueryModel
    {
        public AllMovieQueryModel()
        {
            CurrentPage = DefaultPage;
            MoviesPerPage = EntitiesPerPage;

            Movies = new HashSet<AllMovieViewModel>();
        }

        [Display(Name = "Search title:")]
        public string? Title { get; set; }

        [Display(Name = "Sort by:")]
        public MovieSorting? MovieSorting { get; set; }

        public int CurrentPage { get; set; }

        public int MoviesPerPage { get; set; }

        public int TotalMovies { get; set; }

        public IEnumerable<AllMovieViewModel> Movies { get; set; }
    }
}
