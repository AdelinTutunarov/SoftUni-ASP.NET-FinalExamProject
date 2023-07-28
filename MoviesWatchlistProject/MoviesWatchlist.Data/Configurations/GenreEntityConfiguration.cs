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
                Id = 1,
                Name = "Action"
            };
            genres.Add(genre);

            genre = new Genre()
            {
                Id = 2,
                Name = "Comedy"
            };
            genres.Add(genre);

            genre = new Genre()
            {
                Id = 3,
                Name = "Drama"
            };
            genres.Add(genre);

            genre = new Genre()
            {
                Id = 4,
                Name = "Fantasy"
            };
            genres.Add(genre);

            genre = new Genre()
            {
                Id = 5,
                Name = "Horror"
            };
            genres.Add(genre);

            genre = new Genre()
            {
                Id = 6,
                Name = "Mystery"
            };
            genres.Add(genre);

            genre = new Genre()
            {
                Id = 7,
                Name = "Romance"
            };
            genres.Add(genre);

            genre = new Genre()
            {
                Id = 8,
                Name = "Thriller"
            };
            genres.Add(genre);

            genre = new Genre()
            {
                Id = 9,
                Name = "Crime"
            };
            genres.Add(genre);

            genre = new Genre()
            {
                Id = 10,
                Name = "Psychological"
            };
            genres.Add(genre);

            genre = new Genre()
            {
                Id = 11,
                Name = "Western"
            };
            genres.Add(genre);

            genre = new Genre()
            {
                Id = 12,
                Name = "War and military"
            };
            genres.Add(genre);

            genre = new Genre()
            {
                Id = 13,
                Name = "Martial arts"
            };
            genres.Add(genre);

            genre = new Genre()
            {
                Id = 14,
                Name = "Sci-Fi"
            };
            genres.Add(genre);

            genre = new Genre()
            {
                Id = 15,
                Name = "Historical"
            };
            genres.Add(genre);

            genre = new Genre()
            {
                Id = 16,
                Name = "Supernatural"
            };
            genres.Add(genre);

            genre = new Genre()
            {
                Id = 17,
                Name = "Sports"
            };
            genres.Add(genre);

            genre = new Genre()
            {
                Id = 18,
                Name = "Adventure"
            };
            genres.Add(genre);

            return genres.ToArray();
        }
    }
}
