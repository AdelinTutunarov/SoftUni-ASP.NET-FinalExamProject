using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MoviesWatchlist.Data.Models;

namespace MoviesWatchlist.Data.Configurations
{
    public class GenreEntityConfiguration : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.HasData(GenerateGenres());
        }

        private Genre[] GenerateGenres()
        {
            ICollection<Genre> genres = new HashSet<Genre>();

            Genre genre;

            genre = new Genre()
            {
                Name = "Action"
            };
            genres.Add(genre);

            genre = new Genre()
            {
                Name = "Comedy"
            };
            genres.Add(genre);

            genre = new Genre()
            {
                Name = "Drama"
            };
            genres.Add(genre);

            genre = new Genre()
            {
                Name = "Fantasy"
            };
            genres.Add(genre);

            genre = new Genre()
            {
                Name = "Horror"
            };
            genres.Add(genre);

            genre = new Genre()
            {
                Name = "Mystery"
            };
            genres.Add(genre);

            genre = new Genre()
            {
                Name = "Romance"
            };
            genres.Add(genre);

            genre = new Genre()
            {
                Name = "Thriller"
            };
            genres.Add(genre);

            genre = new Genre()
            {
                Name = "Crime"
            };
            genres.Add(genre);

            genre = new Genre()
            {
                Name = "Psychological"
            };
            genres.Add(genre);

            genre = new Genre()
            {
                Name = "Western"
            };
            genres.Add(genre);

            genre = new Genre()
            {
                Name = "War and military"
            };
            genres.Add(genre);

            genre = new Genre()
            {
                Name = "Martial arts"
            };
            genres.Add(genre);

            genre = new Genre()
            {
                Name = "Sci-Fi"
            };
            genres.Add(genre);

            genre = new Genre()
            {
                Name = "Historical"
            };
            genres.Add(genre);

            genre = new Genre()
            {
                Name = "Supernatural"
            };
            genres.Add(genre);

            genre = new Genre()
            {
                Name = "Sports"
            };
            genres.Add(genre);

            genre = new Genre()
            {
                Name = "Adventure"
            };
            genres.Add(genre);

            return genres.ToArray();
        }
    }
}
