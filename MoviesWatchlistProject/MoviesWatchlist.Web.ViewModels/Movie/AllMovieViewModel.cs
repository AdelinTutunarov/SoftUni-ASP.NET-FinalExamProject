using System.ComponentModel.DataAnnotations;

namespace MoviesWatchlist.Web.ViewModels.Movie
{
    public class AllMovieViewModel
    {
        public string Id { get; set; } = null!;

        public string Title { get; set; } = null!;

        [Display(Name = "Image Link")]
        public string ImgURL { get; set; } = null!;

        public decimal Rating { get; set; }

        [Display(Name = "Release year")]
        public int ReleaseYear { get; set; }
    }
}
