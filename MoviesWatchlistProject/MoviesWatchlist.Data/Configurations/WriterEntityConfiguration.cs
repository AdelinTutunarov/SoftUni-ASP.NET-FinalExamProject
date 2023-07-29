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
                Nationality = "Mexican-American"
            };
            writers.Add(writer);

            writer = new Writer()
            {
                FirstName = "Alex",
                LastName = "Kurtzman",
                Nationality = "American"
            };
            writers.Add(writer);

            writer = new Writer()
            {
                FirstName = "John",
                LastName = "Rogers",
                Nationality = "American"
            };
            writers.Add(writer);

            writer = new Writer()
            {
                FirstName = "Ehren",
                LastName = "Kruger",
                Nationality = "American"
            };
            writers.Add(writer);

            writer = new Writer()
            {
                FirstName = "Ken",
                LastName = "Nolan",
                Nationality = "American"
            };
            writers.Add(writer);

            writer = new Writer()
            {
                FirstName = "Art",
                LastName = "Marcum",
                Nationality = "American"
            };
            writers.Add(writer);

            writer = new Writer()
            {
                FirstName = "Matt",
                LastName = "Holloway",
                Nationality = "American"
            };
            writers.Add(writer);

            writer = new Writer()
            {
                FirstName = "Christina",
                LastName = "Hodson",
                Nationality = "British"
            };
            writers.Add(writer);

            writer = new Writer()
            {
                FirstName = "Mark",
                LastName = "Fergus",
                Nationality = "American"
            };
            writers.Add(writer);

            writer = new Writer()
            {
                FirstName = "Hawk",
                LastName = "Ostby",
                Nationality = "American"
            };
            writers.Add(writer);

            writer = new Writer()
            {
                FirstName = "Justin",
                LastName = "Theroux",
                Nationality = "American"
            };
            writers.Add(writer);

            writer = new Writer()
            {
                FirstName = "Chris",
                LastName = "McKenna",
                Nationality = "American"
            };
            writers.Add(writer);

            writer = new Writer()
            {
                FirstName = "Erik",
                LastName = "Sommers",
                Nationality = "American"
            };
            writers.Add(writer);

            writer = new Writer()
            {
                FirstName = "Jonathan",
                LastName = "Goldstein",
                Nationality = "American"
            };
            writers.Add(writer);

            writer = new Writer()
            {
                FirstName = "John",
                LastName = "Daley",
                Nationality = "American"
            };
            writers.Add(writer);

            writer = new Writer()
            {
                FirstName = "Christopher",
                LastName = "Ford",
                Nationality = "American"
            };
            writers.Add(writer);

            writer = new Writer()
            {
                FirstName = "Joby",
                LastName = "Harold",
                Nationality = "English"
            };
            writers.Add(writer);

            return writers.ToArray();
        }
    }
}
