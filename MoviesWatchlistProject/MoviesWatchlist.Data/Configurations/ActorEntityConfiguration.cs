using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MoviesWatchlist.Data.Models;

namespace MoviesWatchlist.Data.Configurations
{
    public class ActorEntityConfiguration : IEntityTypeConfiguration<Actor>
    {
        public void Configure(EntityTypeBuilder<Actor> builder)
        {
            builder.HasData(GenerateActors());
        }

        private Actor[] GenerateActors()
        {
            ICollection<Actor> actors = new HashSet<Actor>();

            Actor actor;

            actor = new Actor()
            {
                Id = 1,
                FirstName = "Hugo",
                LastName = "Weaving",
                Nationality = "British"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                Id = 2,
                FirstName = "Shia",
                LastName = "LaBeouf",
                Nationality = "American"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                Id = 3,
                FirstName = "Megan",
                LastName = "Fox",
                Nationality = "American"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                Id = 4,
                FirstName = "Tyrese",
                LastName = "Gibson",
                Nationality = "American"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                Id = 5,
                FirstName = "Joshua",
                LastName = "Duhamel",
                Nationality = "American"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                Id = 6,
                FirstName = "John",
                LastName = "Turturro",
                Nationality = "American"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                Id = 7,
                FirstName = "Mark",
                LastName = "Wahlberg",
                Nationality = "American"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                Id = 8,
                FirstName = "Stanley",
                LastName = "Tucci",
                Nationality = "American"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                Id = 9,
                FirstName = "Anthony",
                LastName = "Hopkins",
                Nationality = "Welsh"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                Id = 10,
                FirstName = "Hailee",
                LastName = "Steinfeld",
                Nationality = "American"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                Id = 11,
                FirstName = "John",
                LastName = "Cena",
                Nationality = "American"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                Id = 12,
                FirstName = "John",
                LastName = "Ortiz",
                Nationality = "American"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                Id = 13,
                FirstName = "Anthony",
                LastName = "Ramos",
                Nationality = "American"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                Id = 14,
                FirstName = "Dominique",
                LastName = "Fishback",
                Nationality = "American"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                Id = 15,
                FirstName = "Robert",
                LastName = "Downey Jr.",
                Nationality = "American"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                Id = 16,
                FirstName = "Terrence",
                LastName = "Howard",
                Nationality = "American"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                Id = 17,
                FirstName = "Gwyneth",
                LastName = "Paltrow",
                Nationality = "American"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                Id = 18,
                FirstName = "Scarlett",
                LastName = "Johansson",
                Nationality = "American"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                Id = 19,
                FirstName = "Samuel",
                LastName = "Jackson",
                Nationality = "American"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                Id = 20,
                FirstName = "Tom",
                LastName = "Holland",
                Nationality = "English"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                Id = 21,
                FirstName = "Michael",
                LastName = "Keaton",
                Nationality = "American"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                Id = 22,
                FirstName = "Zendaya",
                LastName = "Coleman",
                Nationality = "American"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                Id = 23,
                FirstName = "Jacob",
                LastName = "Batalon",
                Nationality = "American"
            };
            actors.Add(actor);

            return actors.ToArray();
        }
    }
}
