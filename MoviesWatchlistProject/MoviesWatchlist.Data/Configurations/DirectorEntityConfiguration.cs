using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MoviesWatchlist.Data.Models;

namespace MoviesWatchlist.Data.Configurations
{
    public class DirectorEntityConfiguration : IEntityTypeConfiguration<Director>
    {
        public void Configure(EntityTypeBuilder<Director> builder)
        {
            builder.HasData(GenerateDirectors());
        }

        private Director[] GenerateDirectors()
        {
            ICollection<Director> directors = new HashSet<Director>();

            Director director;

            director = new Director()
            {
                Id = 1,
                FirstName = "Michael",
                LastName = "Bay",
                Nationality = "American"
            };
            directors.Add(director);

            director = new Director()
            {
                Id = 2,
                FirstName = "Travis",
                LastName = "Knight",
                Nationality = "American"
            };
            directors.Add(director);

            director = new Director()
            {
                Id = 3,
                FirstName = "Steven",
                LastName = "Caple Jr.",
                Nationality = "American"
            };
            directors.Add(director);

            director = new Director()
            {
                Id = 4,
                FirstName = "Jonathan",
                LastName = "Favreau",
                Nationality = "American"
            };
            directors.Add(director);

            director = new Director()
            {
                Id = 5,
                FirstName = "Jonathan",
                LastName = "Watts",
                Nationality = "American"
            };
            directors.Add(director);

            return directors.ToArray();
        }
    }
}
