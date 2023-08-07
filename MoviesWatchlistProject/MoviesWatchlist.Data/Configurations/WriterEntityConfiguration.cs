using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MoviesWatchlist.Data.Models;

namespace MoviesWatchlist.Data.Configurations
{
    public class WriterEntityConfiguration : IEntityTypeConfiguration<Writer>
    {
        public void Configure(EntityTypeBuilder<Writer> builder)
        {
            builder.HasData(GenerateWriters());
        }

        private Writer[] GenerateWriters()
        {
            ICollection<Writer> writers = new HashSet<Writer>();

            Writer writer;

            writer = new Writer()
            {
                FirstName = "Roberto",
                LastName = "Orci",
                Nationality = "Mexican-American",
                ImageURL = "https://en.wikipedia.org/wiki/Roberto_Orci#/media/File:Roberto_Orci_by_Gage_Skidmore.jpg"
            };
            writers.Add(writer);

            writer = new Writer()
            {
                FirstName = "Alex",
                LastName = "Kurtzman",
                Nationality = "American",
                ImageURL = "https://en.wikipedia.org/wiki/Alex_Kurtzman#/media/File:Alex_Kurtzman_San_Diego_Comic_Con_2019.jpg"
            };
            writers.Add(writer);

            writer = new Writer()
            {
                FirstName = "John",
                LastName = "Rogers",
                Nationality = "American",
                ImageURL = "https://en.wikipedia.org/wiki/John_Rogers_(writer)#/media/File:John_Rogers_(971464822)_(cropped).jpg"
            };
            writers.Add(writer);

            writer = new Writer()
            {
                FirstName = "Ehren",
                LastName = "Kruger",
                Nationality = "American",
                ImageURL = "https://www.freepik.com/free-photo/user-profile-icon-front-side_41949685.htm#query=default%20avatar%20profile&position=3&from_view=search&track=ais"
            };
            writers.Add(writer);

            writer = new Writer()
            {
                FirstName = "Ken",
                LastName = "Nolan",
                Nationality = "American",
                ImageURL = "https://www.freepik.com/free-photo/user-profile-icon-front-side_41949685.htm#query=default%20avatar%20profile&position=3&from_view=search&track=ais"
            };
            writers.Add(writer);

            writer = new Writer()
            {
                FirstName = "Art",
                LastName = "Marcum",
                Nationality = "American",
                ImageURL = "https://www.freepik.com/free-photo/user-profile-icon-front-side_41949685.htm#query=default%20avatar%20profile&position=3&from_view=search&track=ais"
            };
            writers.Add(writer);

            writer = new Writer()
            {
                FirstName = "Matt",
                LastName = "Holloway",
                Nationality = "American",
                ImageURL = "https://www.freepik.com/free-photo/user-profile-icon-front-side_41949685.htm#query=default%20avatar%20profile&position=3&from_view=search&track=ais"
            };
            writers.Add(writer);

            writer = new Writer()
            {
                FirstName = "Christina",
                LastName = "Hodson",
                Nationality = "British",
                ImageURL = "https://en.wikipedia.org/wiki/Christina_Hodson#/media/File:Christina_Hodson.jpg"
            };
            writers.Add(writer);

            writer = new Writer()
            {
                FirstName = "Mark",
                LastName = "Fergus",
                Nationality = "American",
                ImageURL = "https://www.freepik.com/free-photo/user-profile-icon-front-side_41949685.htm#query=default%20avatar%20profile&position=3&from_view=search&track=ais"
            };
            writers.Add(writer);

            writer = new Writer()
            {
                FirstName = "Hawk",
                LastName = "Ostby",
                Nationality = "American",
                ImageURL = "https://en.wikipedia.org/wiki/Mark_Fergus_and_Hawk_Ostby#/media/File:Hawk_Ostby,_at_the_Hugo_Awards_Ceremony,_Worldcon,_Helsinki.jpg"
            };
            writers.Add(writer);

            writer = new Writer()
            {
                FirstName = "Justin",
                LastName = "Theroux",
                Nationality = "American",
                ImageURL = "https://en.wikipedia.org/wiki/Justin_Theroux#/media/File:Maniac_UK_premiere_(Theroux).jpg"
            };
            writers.Add(writer);

            writer = new Writer()
            {
                FirstName = "Chris",
                LastName = "McKenna",
                Nationality = "American",
                ImageURL = "https://en.wikipedia.org/wiki/Chris_McKenna_(writer)#/media/File:Chris_McKenna_(14584155278).jpg"
            };
            writers.Add(writer);

            writer = new Writer()
            {
                FirstName = "Erik",
                LastName = "Sommers",
                Nationality = "American",
                ImageURL = "https://www.freepik.com/free-photo/user-profile-icon-front-side_41949685.htm#query=default%20avatar%20profile&position=3&from_view=search&track=ais"
            };
            writers.Add(writer);

            writer = new Writer()
            {
                FirstName = "Jonathan",
                LastName = "Goldstein",
                Nationality = "American",
                ImageURL = "https://www.freepik.com/free-photo/user-profile-icon-front-side_41949685.htm#query=default%20avatar%20profile&position=3&from_view=search&track=ais"
            };
            writers.Add(writer);

            writer = new Writer()
            {
                FirstName = "John",
                LastName = "Daley",
                Nationality = "American",
                ImageURL = "https://en.wikipedia.org/wiki/John_Francis_Daley#/media/File:John_Francis_Daley_in_March_2012.jpg"
            };
            writers.Add(writer);

            writer = new Writer()
            {
                FirstName = "Christopher",
                LastName = "Ford",
                Nationality = "American",
                ImageURL = "https://www.freepik.com/free-photo/user-profile-icon-front-side_41949685.htm#query=default%20avatar%20profile&position=3&from_view=search&track=ais"
            };
            writers.Add(writer);

            writer = new Writer()
            {
                FirstName = "Joby",
                LastName = "Harold",
                Nationality = "English",
                ImageURL = "https://en.wikipedia.org/wiki/Joby_Harold#/media/File:Joby_Harold_on_Sidewalks_Entertainment.jpg"
            };
            writers.Add(writer);

            return writers.ToArray();
        }
    }
}
