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
                ImageURL = "https://en.wikipedia.org/wiki/Michael_Bay_filmography#/media/File:Michael.bay.png"
            };
            directors.Add(director);

            director = new Director()
            {
                FirstName = "Travis",
                LastName = "Knight",
                Nationality = "American",
                ImageURL = "https://en.wikipedia.org/wiki/Travis_Knight#/media/File:Travis_Knight_(30000495292).jpg"
            };
            directors.Add(director);

            director = new Director()
            {
                FirstName = "Steven",
                LastName = "Caple Jr.",
                Nationality = "American",
                ImageURL = "https://www.freepik.com/free-photo/user-profile-icon-front-side_41949685.htm#query=default%20avatar%20profile&position=3&from_view=search&track=ais"
            };
            directors.Add(director);

            director = new Director()
            {
                FirstName = "Jonathan",
                LastName = "Favreau",
                Nationality = "American",
                ImageURL = "https://en.wikipedia.org/wiki/Jon_Favreau#/media/File:Jon_Favreau_2016.jpeg"
            };
            directors.Add(director);

            director = new Director()
            {
                FirstName = "Jonathan",
                LastName = "Watts",
                Nationality = "American",
                ImageURL = "https://en.wikipedia.org/wiki/Jon_Watts#/media/File:Jon_Watts_by_Gage_Skidmore_2.jpg"
            };
            directors.Add(director);

            return directors.ToArray();
        }
    }
}
