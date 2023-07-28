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
                Id = 1,
                FirstName = "Roberto",
                LastName = "Orci",
                Nationality = "Mexican-American"
            };
            writers.Add(writer);

            writer = new Writer()
            {
                Id = 2,
                FirstName = "Alex",
                LastName = "Kurtzman",
                Nationality = "American"
            };
            writers.Add(writer);

            writer = new Writer()
            {
                Id = 3,
                FirstName = "John",
                LastName = "Rogers",
                Nationality = "American"
            };
            writers.Add(writer);

            writer = new Writer()
            {
                Id = 4,
                FirstName = "Ehren",
                LastName = "Kruger",
                Nationality = "American"
            };
            writers.Add(writer);

            writer = new Writer()
            {
                Id = 5,
                FirstName = "Ken",
                LastName = "Nolan",
                Nationality = "American"
            };
            writers.Add(writer);

            writer = new Writer()
            {
                Id = 6,
                FirstName = "Art",
                LastName = "Marcum",
                Nationality = "American"
            };
            writers.Add(writer);

            writer = new Writer()
            {
                Id = 7,
                FirstName = "Matt",
                LastName = "Holloway",
                Nationality = "American"
            };
            writers.Add(writer);

            writer = new Writer()
            {
                Id = 8,
                FirstName = "Christina",
                LastName = "Hodson",
                Nationality = "British"
            };
            writers.Add(writer);

            writer = new Writer()
            {
                Id = 9,
                FirstName = "Mark",
                LastName = "Fergus",
                Nationality = "American"
            };
            writers.Add(writer);

            writer = new Writer()
            {
                Id = 10,
                FirstName = "Hawk",
                LastName = "Ostby",
                Nationality = "American"
            };
            writers.Add(writer);

            writer = new Writer()
            {
                Id = 11,
                FirstName = "Justin",
                LastName = "Theroux",
                Nationality = "American"
            };
            writers.Add(writer);

            writer = new Writer()
            {
                Id = 12,
                FirstName = "Chris",
                LastName = "McKenna",
                Nationality = "American"
            };
            writers.Add(writer);

            writer = new Writer()
            {
                Id = 13,
                FirstName = "Erik",
                LastName = "Sommers",
                Nationality = "American"
            };
            writers.Add(writer);

            writer = new Writer()
            {
                Id = 14,
                FirstName = "Jonathan",
                LastName = "Goldstein",
                Nationality = "American"
            };
            writers.Add(writer);

            writer = new Writer()
            {
                Id = 15,
                FirstName = "John",
                LastName = "Daley",
                Nationality = "American"
            };
            writers.Add(writer);

            writer = new Writer()
            {
                Id = 16,
                FirstName = "Christopher",
                LastName = "Ford",
                Nationality = "American"
            };
            writers.Add(writer);

            writer = new Writer()
            {
                Id = 17,
                FirstName = "Joby",
                LastName = "Harold",
                Nationality = "English"
            };
            writers.Add(writer);

            return writers.ToArray();
        }
    }
}
