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
                FirstName = "Michael",
                LastName = "Bay",
                Nationality = "American"
            };
            directors.Add(director);

            director = new Director()
            {
                FirstName = "Travis",
                LastName = "Knight",
                Nationality = "American"
            };
            directors.Add(director);

            director = new Director()
            {
                FirstName = "Steven",
                LastName = "Caple Jr.",
                Nationality = "American"
            };
            directors.Add(director);

            director = new Director()
            {
                FirstName = "Jonathan",
                LastName = "Favreau",
                Nationality = "American"
            };
            directors.Add(director);

            director = new Director()
            {
                FirstName = "Jonathan",
                LastName = "Watts",
                Nationality = "American"
            };
            directors.Add(director);

            return directors.ToArray();
        }
    }
}
