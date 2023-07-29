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
                FirstName = "Hugo",
                LastName = "Weaving",
                Nationality = "British"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                FirstName = "Shia",
                LastName = "LaBeouf",
                Nationality = "American"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                FirstName = "Megan",
                LastName = "Fox",
                Nationality = "American"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                FirstName = "Tyrese",
                LastName = "Gibson",
                Nationality = "American"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                FirstName = "Joshua",
                LastName = "Duhamel",
                Nationality = "American"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                FirstName = "John",
                LastName = "Turturro",
                Nationality = "American"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                FirstName = "Mark",
                LastName = "Wahlberg",
                Nationality = "American"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                FirstName = "Stanley",
                LastName = "Tucci",
                Nationality = "American"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                FirstName = "Anthony",
                LastName = "Hopkins",
                Nationality = "Welsh"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                FirstName = "Hailee",
                LastName = "Steinfeld",
                Nationality = "American"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                FirstName = "John",
                LastName = "Cena",
                Nationality = "American"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                FirstName = "John",
                LastName = "Ortiz",
                Nationality = "American"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                FirstName = "Anthony",
                LastName = "Ramos",
                Nationality = "American"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                FirstName = "Dominique",
                LastName = "Fishback",
                Nationality = "American"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                FirstName = "Robert",
                LastName = "Downey Jr.",
                Nationality = "American"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                FirstName = "Terrence",
                LastName = "Howard",
                Nationality = "American"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                FirstName = "Gwyneth",
                LastName = "Paltrow",
                Nationality = "American"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                FirstName = "Scarlett",
                LastName = "Johansson",
                Nationality = "American"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                FirstName = "Samuel",
                LastName = "Jackson",
                Nationality = "American"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                FirstName = "Tom",
                LastName = "Holland",
                Nationality = "English"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                FirstName = "Michael",
                LastName = "Keaton",
                Nationality = "American"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                FirstName = "Zendaya",
                LastName = "Coleman",
                Nationality = "American"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                FirstName = "Jacob",
                LastName = "Batalon",
                Nationality = "American"
            };
            actors.Add(actor);

            return actors.ToArray();
        }
    }
}
