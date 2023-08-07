using System.ComponentModel.DataAnnotations;

namespace MoviesWatchlist.Web.ViewModels.Genre
{
    public class AllGenreViewModel
    {
        public string Id { get; set; } = null!;

        [Display(Name = "Genre")]
        public string GenreName { get; set; } = null!;

        [Display(Name = "Image Link")]
        public string ImgURL { get; set; } = null!;
    }
}
