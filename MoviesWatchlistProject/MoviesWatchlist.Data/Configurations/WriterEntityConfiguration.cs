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
                ImageURL = "https://variety.com/wp-content/uploads/2014/05/roberto-orci.jpg"
            };
            writers.Add(writer);

            writer = new Writer()
            {
                FirstName = "Alex",
                LastName = "Kurtzman",
                Nationality = "American",
                ImageURL = "https://www.startrek.com/sites/default/files/styles/content_full/public/images/2019-07/b58f7d184743106a8a66028b7a28937c.jpg?itok=WAC4Y1l3"
            };
            writers.Add(writer);

            writer = new Writer()
            {
                FirstName = "John",
                LastName = "Rogers",
                Nationality = "American",
                ImageURL = "https://bioelectronics.northwestern.edu/images/people/members/rogers-john.jpg"
            };
            writers.Add(writer);

            writer = new Writer()
            {
                FirstName = "Ehren",
                LastName = "Kruger",
                Nationality = "American",
                ImageURL = "https://m.media-amazon.com/images/M/MV5BMTc4Nzk4NTg2Nl5BMl5BanBnXkFtZTYwNTQ4OTU3._V1_.jpg"
            };
            writers.Add(writer);

            writer = new Writer()
            {
                FirstName = "Ken",
                LastName = "Nolan",
                Nationality = "American",
                ImageURL = "https://images.mubicdn.net/images/cast_member/16761/cache-259975-1506415601/image-w856.jpg?size=800x"
            };
            writers.Add(writer);

            writer = new Writer()
            {
                FirstName = "Art",
                LastName = "Marcum",
                Nationality = "American",
                ImageURL = "https://scriptmag.com/.image/t_share/MTg3Nzg2ODU1Nzc1NzQxMjcz/artmarcum.jpg"
            };
            writers.Add(writer);

            writer = new Writer()
            {
                FirstName = "Matt",
                LastName = "Holloway",
                Nationality = "American",
                ImageURL = "https://ausdrain.com/wp-content/uploads/2018/03/Matt-ausdain-tile-1-e1607646121344-576x380.jpg"
            };
            writers.Add(writer);

            writer = new Writer()
            {
                FirstName = "Christina",
                LastName = "Hodson",
                Nationality = "British",
                ImageURL = "https://i0.wp.com/geeksofcolor.co/wp-content/uploads/2018/04/1-ex0dre0izo58_qehqtglbw.jpg?resize=800%2C469&ssl=1"
            };
            writers.Add(writer);

            writer = new Writer()
            {
                FirstName = "Mark",
                LastName = "Fergus",
                Nationality = "American",
                ImageURL = "https://static.wikia.nocookie.net/marvelcinematicuniverse/images/4/47/Mark_Fergus.jpg/revision/latest?cb=20120922000533"
            };
            writers.Add(writer);

            writer = new Writer()
            {
                FirstName = "Hawk",
                LastName = "Ostby",
                Nationality = "American",
                ImageURL = "https://variety.com/wp-content/uploads/2013/09/hawk-ostby-mark-fergus.jpg?w=1000"
            };
            writers.Add(writer);

            writer = new Writer()
            {
                FirstName = "Justin",
                LastName = "Theroux",
                Nationality = "American",
                ImageURL = "https://media-cldnry.s-nbcnews.com/image/upload/rockcms/2023-05/justin-Theroux-Jennifer-Aniston-te-230501-5e6504.jpg"
            };
            writers.Add(writer);

            writer = new Writer()
            {
                FirstName = "Chris",
                LastName = "McKenna",
                Nationality = "American",
                ImageURL = "https://1.bp.blogspot.com/-Hef2MXW2WhM/W-Es5fvF8eI/AAAAAAAALUo/9AvYphdbpUU5XHAJaMmIXiiKdj-FsuDwwCLcBGAs/s1600/ChrisMc.jpeg"
            };
            writers.Add(writer);

            writer = new Writer()
            {
                FirstName = "Erik",
                LastName = "Sommers",
                Nationality = "American",
                ImageURL = "https://static.wikia.nocookie.net/marvelcinematicuniverse/images/7/7a/Erik_Sommers.png/revision/latest?cb=20210927114539"
            };
            writers.Add(writer);

            writer = new Writer()
            {
                FirstName = "Jonathan",
                LastName = "Goldstein",
                Nationality = "American",
                ImageURL = "https://i.guim.co.uk/img/media/254c8463684b9022559adeffd4162424a52008d5/0_175_3456_2073/master/3456.jpg?width=1200&height=630&quality=85&auto=format&fit=crop&overlay-align=bottom%2Cleft&overlay-width=100p&overlay-base64=L2ltZy9zdGF0aWMvb3ZlcmxheXMvdGctZGVmYXVsdC5wbmc&s=d9f4c5375c148042bf815c6f09fd1ae6"
            };
            writers.Add(writer);

            writer = new Writer()
            {
                FirstName = "John",
                LastName = "Daley",
                Nationality = "American",
                ImageURL = "https://flxt.tmsimg.com/assets/189544_v9_bb.jpg"
            };
            writers.Add(writer);

            writer = new Writer()
            {
                FirstName = "Christopher",
                LastName = "Ford",
                Nationality = "American",
                ImageURL = "https://static.wikia.nocookie.net/marvelcinematicuniverse/images/c/c2/Christopher_Ford.jpg/revision/latest?cb=20210927095630"
            };
            writers.Add(writer);

            writer = new Writer()
            {
                FirstName = "Joby",
                LastName = "Harold",
                Nationality = "English",
                ImageURL = "https://www.comingsoon.net/wp-content/uploads/sites/3/2020/04/jobyharold.jpg?w=800"
            };
            writers.Add(writer);

            return writers.ToArray();
        }
    }
}
