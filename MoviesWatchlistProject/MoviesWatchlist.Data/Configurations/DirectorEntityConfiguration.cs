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
                Nationality = "American",
                ImageURL = "https://deadline.com/wp-content/uploads/2022/12/Michael-Bay.jpg"
            };
            directors.Add(director);

            director = new Director()
            {
                FirstName = "Travis",
                LastName = "Knight",
                Nationality = "American",
                ImageURL = "https://deadline.com/wp-content/uploads/2020/01/shutterstock_editorial_10540803ev-e1580315841789.jpg"
            };
            directors.Add(director);

            director = new Director()
            {
                FirstName = "Steven",
                LastName = "Caple Jr.",
                Nationality = "American",
                ImageURL = "https://images.bauerhosting.com/empire/2023/06/steven-caple-jr.jpg?format=jpg&quality=80&width=960&height=540&ratio=16-9&resize=aspectfill"
            };
            directors.Add(director);

            director = new Director()
            {
                FirstName = "Jonathan",
                LastName = "Favreau",
                Nationality = "American",
                ImageURL = "https://lumiere-a.akamaihd.net/v1/images/jon-favreau-hollywood-walk-of-fame-feature_464fe901.jpeg"
            };
            directors.Add(director);

            director = new Director()
            {
                FirstName = "Jonathan",
                LastName = "Watts",
                Nationality = "American",
                ImageURL = "https://variety.com/wp-content/uploads/2022/04/Jon-Watts.jpg?w=1000"
            };
            directors.Add(director);

            return directors.ToArray();
        }
    }
}
