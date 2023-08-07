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
                ImageURL = "https://en.wikipedia.org/wiki/Hugo_Weaving#/media/File:MJK_08925_Hugo_Weaving_(Berlinale_2018)_bw43.jpg"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                FirstName = "Shia",
                LastName = "LaBeouf",
                Nationality = "American",
                ImageURL = "https://en.wikipedia.org/wiki/Shia_LaBeouf#/media/File:Shia_LaBeouf_2022.jpg"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                FirstName = "Megan",
                LastName = "Fox",
                Nationality = "American",
                ImageURL = "https://en.wikipedia.org/wiki/Megan_Fox#/media/File:Machine_Gun_Kelly_and_Megan_Fox_(51914406561)_(cropped2).jpg"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                FirstName = "Tyrese",
                LastName = "Gibson",
                Nationality = "American",
                ImageURL = "https://en.wikipedia.org/wiki/Tyrese_Gibson#/media/File:TyreseGibsonDec08.jpg"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                FirstName = "Joshua",
                LastName = "Duhamel",
                Nationality = "American",
                ImageURL = "https://en.wikipedia.org/wiki/Josh_Duhamel#/media/File:Josh_Duhamel_SXSW_2017_(cropped).jpg"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                FirstName = "John",
                LastName = "Turturro",
                Nationality = "American",
                ImageURL = "https://en.wikipedia.org/wiki/John_Turturro#/media/File:John_Turturro_2017.jpg"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                FirstName = "Mark",
                LastName = "Wahlberg",
                Nationality = "American",
                ImageURL = "https://en.wikipedia.org/wiki/Mark_Wahlberg#/media/File:Mark_Wahlberg_2021.jpg"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                FirstName = "Stanley",
                LastName = "Tucci",
                Nationality = "American",
                ImageURL = "https://en.wikipedia.org/wiki/Stanley_Tucci#/media/File:Stanley_Tucci_2017_Berlinale.jpg"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                FirstName = "Anthony",
                LastName = "Hopkins",
                Nationality = "Welsh",
                ImageURL = "https://en.wikipedia.org/wiki/Anthony_Hopkins#/media/File:AnthonyHopkins10TIFF.jpg"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                FirstName = "Hailee",
                LastName = "Steinfeld",
                Nationality = "American",
                ImageURL = "https://en.wikipedia.org/wiki/Hailee_Steinfeld#/media/File:Hailee_Steinfeld_by_Gage_Skidmore.jpg"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                FirstName = "John",
                LastName = "Cena",
                Nationality = "American",
                ImageURL = "https://en.wikipedia.org/wiki/John_Cena#/media/File:John_Cena_July_2018.jpg"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                FirstName = "John",
                LastName = "Ortiz",
                Nationality = "American",
                ImageURL = "https://en.wikipedia.org/wiki/John_Ortiz#/media/File:John_Ortiz_2019.jpg"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                FirstName = "Anthony",
                LastName = "Ramos",
                Nationality = "American",
                ImageURL = "https://en.wikipedia.org/wiki/Anthony_Ramos#/media/File:Anthony_Ramos_(cropped).jpg"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                FirstName = "Dominique",
                LastName = "Fishback",
                Nationality = "American",
                ImageURL = "https://en.wikipedia.org/wiki/Dominique_Fishback#/media/File:TIFF_2018_Dominique_Fishback_(1_of_1)-2.jpg"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                FirstName = "Robert",
                LastName = "Downey Jr.",
                Nationality = "American",
                ImageURL = "https://en.wikipedia.org/wiki/Robert_Downey_Jr.#/media/File:Robert_Downey_Jr_2014_Comic_Con_(cropped).jpg"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                FirstName = "Terrence",
                LastName = "Howard",
                Nationality = "American",
                ImageURL = "https://en.wikipedia.org/wiki/Terrence_Howard#/media/File:Terrence_Howard.jpg"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                FirstName = "Gwyneth",
                LastName = "Paltrow",
                Nationality = "American",
                ImageURL = "https://en.wikipedia.org/wiki/Gwyneth_Paltrow#/media/File:GwynethPaltrowByAndreaRaffin2011.jpg"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                FirstName = "Scarlett",
                LastName = "Johansson",
                Nationality = "American",
                ImageURL = "https://en.wikipedia.org/wiki/Scarlett_Johansson#/media/File:Scarlett_Johansson_by_Gage_Skidmore_2_(cropped,_2).jpg"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                FirstName = "Samuel",
                LastName = "Jackson",
                Nationality = "American",
                ImageURL = "https://en.wikipedia.org/wiki/Samuel_L._Jackson"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                FirstName = "Tom",
                LastName = "Holland",
                Nationality = "English",
                ImageURL = "https://en.wikipedia.org/wiki/Tom_Holland#/media/File:Tom_Holland_by_Gage_Skidmore.jpg"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                FirstName = "Michael",
                LastName = "Keaton",
                Nationality = "American",
                ImageURL = "https://en.wikipedia.org/wiki/Michael_Keaton#/media/File:Michael_Keaton_(NYCC_2014)_(cropped).JPG"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                FirstName = "Zendaya",
                LastName = "Coleman",
                Nationality = "American",
                ImageURL = "https://en.wikipedia.org/wiki/Zendaya#/media/File:Zendaya_-_2019_by_Glenn_Francis.jpg"
            };
            actors.Add(actor);

            actor = new Actor()
            {
                FirstName = "Jacob",
                LastName = "Batalon",
                Nationality = "American",
                ImageURL = "https://en.wikipedia.org/wiki/Jacob_Batalon#/media/File:Jacob_Batalon_(28035642754)_(cropped).jpg"
            };
            actors.Add(actor);

            return actors.ToArray();
        }
    }
}
