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
                Nationality = "British",
                ImageURL = "https://content.api.news/v3/images/bin/7a755d9f3876f67a85751897275918ac?width=2048"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                FirstName = "Shia",
                LastName = "LaBeouf",
                Nationality = "American",
                ImageURL = "https://variety.com/wp-content/uploads/2022/08/GettyImages-1185815950-e1661558394757.jpg"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                FirstName = "Megan",
                LastName = "Fox",
                Nationality = "American",
                ImageURL = "https://hips.hearstapps.com/hmg-prod/images/gettyimages-843456920.jpg?crop=1xw:0.75xh"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                FirstName = "Tyrese",
                LastName = "Gibson",
                Nationality = "American",
                ImageURL = "https://img.buzzfeed.com/buzzfeed-static/complex/images/rfkcideekykilq6nxfdy/morbius-tyrese-gibson-interview.jpg"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                FirstName = "Joshua",
                LastName = "Duhamel",
                Nationality = "American",
                ImageURL = "https://pagesix.com/wp-content/uploads/sites/3/2018/12/josh-duhamel.jpg?quality=75&strip=all"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                FirstName = "John",
                LastName = "Turturro",
                Nationality = "American",
                ImageURL = "https://www.goldderby.com/wp-content/uploads/2019/02/John-Turturro-movies-Ranked.jpg?w=620&h=360&crop=1"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                FirstName = "Mark",
                LastName = "Wahlberg",
                Nationality = "American",
                ImageURL = "https://s.yimg.com/ny/api/res/1.2/Dv95XwJFZgODyyUkNF1j6A--/YXBwaWQ9aGlnaGxhbmRlcjt3PTY0MDtoPTQ4MA--/https://media.zenfs.com/en/people_218/5ace08f208b3ced146f0aefe54f840e8"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                FirstName = "Stanley",
                LastName = "Tucci",
                Nationality = "American",
                ImageURL = "https://media.vanityfair.com/photos/6228f56c8e2d9f0117a49745/master/w_2560%2Cc_limit/1342262316"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                FirstName = "Anthony",
                LastName = "Hopkins",
                Nationality = "Welsh",
                ImageURL = "https://static01.nyt.com/images/2021/04/26/arts/26hopkins-oscars/merlin_186923745_91056fad-2aae-40f0-8552-d90324beedee-articleLarge.jpg?quality=75&auto=webp&disable=upscale"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                FirstName = "Hailee",
                LastName = "Steinfeld",
                Nationality = "American",
                ImageURL = "https://m.media-amazon.com/images/M/MV5BZjNiZWZiMjYtNGI3Yy00NzdhLTk5YjEtZTQ2NGMzZmNlYTYxXkEyXkFqcGdeQWZlZGVyaWdh._V1_QL75_UX500_CR0,0,500,281_.jpg"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                FirstName = "John",
                LastName = "Cena",
                Nationality = "American",
                ImageURL = "https://supersport-cms-prod.azureedge.net/media/vblpbdgz/john-cena-looks-on-c-wwe.jpg?width=2048&quality=100"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                FirstName = "John",
                LastName = "Ortiz",
                Nationality = "American",
                ImageURL = "https://deadline.com/wp-content/uploads/2017/02/john-ortiz-2.jpg?w=630&h=383&crop=1"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                FirstName = "Anthony",
                LastName = "Ramos",
                Nationality = "American",
                ImageURL = "https://deadline.com/wp-content/uploads/2022/02/MEGA423535_079-e1644426414259.jpg"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                FirstName = "Dominique",
                LastName = "Fishback",
                Nationality = "American",
                ImageURL = "https://variety.com/wp-content/uploads/2022/03/Dominique-Fishbeck.jpg?w=1000"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                FirstName = "Robert",
                LastName = "Downey Jr.",
                Nationality = "American",
                ImageURL = "https://people.com/thmb/TOOe_Ku31nqQx3va8hZa2EXAiU0=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc():focal(708x354:710x356)/Robert-Downey-Oppenheimer-071523-02-56152238e5064f8c954f688eb0b77cdc.jpg"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                FirstName = "Terrence",
                LastName = "Howard",
                Nationality = "American",
                ImageURL = "https://www.cheatsheet.com/wp-content/uploads/2021/03/Terrence-Howard.jpg"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                FirstName = "Gwyneth",
                LastName = "Paltrow",
                Nationality = "American",
                ImageURL = "https://cdn.britannica.com/56/172456-050-F518B29E/Gwyneth-Paltrow-2013.jpg?w=400&h=300&c=crop"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                FirstName = "Scarlett",
                LastName = "Johansson",
                Nationality = "American",
                ImageURL = "https://nypost.com/wp-content/uploads/sites/2/2023/04/NYPICHPDPICT000007934275.jpg?quality=75&strip=all"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                FirstName = "Samuel",
                LastName = "Jackson",
                Nationality = "American",
                ImageURL = "https://hips.hearstapps.com/hmg-prod/images/gettyimages-648731684.jpg"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                FirstName = "Tom",
                LastName = "Holland",
                Nationality = "English",
                ImageURL = "https://e3.365dm.com/22/08/1600x900/skynews-tom-holland-spider-man_5865167.jpg?20220815095025"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                FirstName = "Michael",
                LastName = "Keaton",
                Nationality = "American",
                ImageURL = "https://www.pittsburghmagazine.com/content/uploads/2022/09/j/t/keaton.jpg"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                FirstName = "Zendaya",
                LastName = "Coleman",
                Nationality = "American",
                ImageURL = "https://static.standard.co.uk/s3fs-public/thumbnails/image/2020/01/13/15/zendaya-130120-09.jpg?width=1200&height=900&fit=crop"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                FirstName = "Jacob",
                LastName = "Batalon",
                Nationality = "American",
                ImageURL = "https://s.abcnews.com/images/GMA/221207_gma_batalon1_hpMain_16x9_1600.jpg"
            };
            actors.Add(actor);

            return actors.ToArray();
        }
    }
}
