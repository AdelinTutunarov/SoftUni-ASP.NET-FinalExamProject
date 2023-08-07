using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MoviesWatchlist.Data.Models;

namespace MoviesWatchlist.Data.Configurations
{
    public class GenreEntityConfiguration : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.HasData(GenerateGenres());
        }

        private Genre[] GenerateGenres()
        {
            ICollection<Genre> genres = new HashSet<Genre>();

            Genre genre;

            genre = new Genre()
            {
                Name = "Action",
                ImageURL = "https://img.freepik.com/free-photo/dictatorship-oppression-collage-concept_23-2149711441.jpg?w=996&t=st=1690645532~exp=1690646132~hmac=8e2d8c552cc98f1c2997af989980015a2b12a42fc5a7a84d167908aeda7c1f4d"
            };
            genres.Add(genre);

            genre = new Genre()
            {
                Name = "Comedy",
                ImageURL = "https://img.freepik.com/free-photo/people-s-emotions-cinema_155003-15059.jpg?w=996&t=st=1690644907~exp=1690645507~hmac=50e982108c2b8eadb7aa524e605a844fc8e1e19a9bfefbceb26495a39c41a4df"
            };
            genres.Add(genre);

            genre = new Genre()
            {
                Name = "Drama",
                ImageURL = "https://img.freepik.com/free-photo/sad-lady-silk-outfit-posing-with-clapperboard-black-background-portrait-blonde-woman-red-dress-crying-isolated-backdrop_197531-29087.jpg?w=996&t=st=1690645002~exp=1690645602~hmac=10686356bde52377f1f022d27be1880fc928717d6d10146a9d82037b199a7a4f"
            };
            genres.Add(genre);

            genre = new Genre()
            {
                Name = "Fantasy",
                ImageURL = "https://img.freepik.com/free-photo/nighttime-nature-landscape-galaxy-mountain-water-star-beauty-generative-ai_188544-9736.jpg?w=1060&t=st=1690645132~exp=1690645732~hmac=033aa5f68de6924948adc05915d4f13d141706979dfa063f5bbd38d11c46f2a4"
            };
            genres.Add(genre);

            genre = new Genre()
            {
                Name = "Horror",
                ImageURL = "https://img.freepik.com/free-photo/small-skeleton-with-popcorn-tv_23-2147685634.jpg?w=996&t=st=1690645054~exp=1690645654~hmac=6445730adc22805a60813820dd00cc71499fd873cee682d3da6d3a5d19e05384"
            };
            genres.Add(genre);

            genre = new Genre()
            {
                Name = "Mystery",
                ImageURL = "https://img.freepik.com/free-photo/back-view-man-planning-hacker-attack-dark-room-man-writing-wall-with-stickers-photographs-red-threads-planning-conspiracy-hacking-concept_74855-24330.jpg?w=996&t=st=1690645169~exp=1690645769~hmac=bb30a31205ec715b8384815bcb7b2b46222b8dedb91e4d0040d7aa30fb9d967f"
            };
            genres.Add(genre);

            genre = new Genre()
            {
                Name = "Romance",
                ImageURL = "https://img.freepik.com/free-photo/silhouettes-wedding-couple-standing-evening-field_1304-5463.jpg?w=1060&t=st=1690645187~exp=1690645787~hmac=40a97b3583ac55b8ef09542220c23c7b1f8b0ea4c059daca4f0455702e9e6464"
            };
            genres.Add(genre);

            genre = new Genre()
            {
                Name = "Thriller",
                ImageURL = "https://img.freepik.com/free-photo/silhouette-scary-zombie-with-dramatic-background_9083-8119.jpg?w=996&t=st=1690645242~exp=1690645842~hmac=3386ca0baa8ae3d240c321b480c46a262886ea6b850f5bfadd42af4ef54a2bdc"
            };
            genres.Add(genre);

            genre = new Genre()
            {
                Name = "Crime",
                ImageURL = "https://img.freepik.com/free-photo/truth-concept-arrangement-crime-scene_23-2149051305.jpg?w=996&t=st=1690645266~exp=1690645866~hmac=2f1dc50b5128517c9d54fb98b7826ec6e5547fe1049f8a402264ecddbaab9c8d"
            };
            genres.Add(genre);

            genre = new Genre()
            {
                Name = "Psychological",
                ImageURL = "https://img.freepik.com/free-photo/memory-loss-dementia-alzheimer-concept-created-with-generative-ai-technology_185193-110044.jpg?w=1060&t=st=1690645384~exp=1690645984~hmac=166a934cabdbc26d34996172eb3b0c404a6ceeb9159f36f15becbf8ca3969194"
            };
            genres.Add(genre);

            genre = new Genre()
            {
                Name = "Western",
                ImageURL = "https://img.freepik.com/free-photo/cowboy-background-with-hat_52683-87191.jpg?w=360&t=st=1690645411~exp=1690646011~hmac=e5b40854dc486b4d7c64ed41e7b3eda36131e28c6f73382e7e3834d9e08354e8"
            };
            genres.Add(genre);

            genre = new Genre()
            {
                Name = "War and military",
                ImageURL = "https://img.freepik.com/free-photo/cruel-war-scenes-digital-painting_456031-162.jpg?w=1380&t=st=1690645434~exp=1690646034~hmac=7f69427ebf3e600fb904d17b3bb3877d1a172ba7194cc4549977ccb61a43dcce"
            };
            genres.Add(genre);

            genre = new Genre()
            {
                Name = "Martial arts",
                ImageURL = "https://www.freepik.com/free-photo/muay-thai-thai-boxing-fighters_27883560.htm#query=fight%20film&position=9&from_view=search&track=ais"
            };
            genres.Add(genre);

            genre = new Genre()
            {
                Name = "Sci-Fi",
                ImageURL = "https://img.freepik.com/free-photo/painting-spaceship-being-lifted-up-by-galaxy_123827-23492.jpg?w=996&t=st=1690645621~exp=1690646221~hmac=e753bce5031804d263d083eb6d69f24ca79a53bf2de5cf5b1c0f126c13ea5790"
            };
            genres.Add(genre);

            genre = new Genre()
            {
                Name = "Historical",
                ImageURL = "https://img.freepik.com/free-photo/beautiful-shot-famous-roman-colosseum-amphitheater-breathtaking-sky-sunrise_181624-6998.jpg?w=900&t=st=1690645693~exp=1690646293~hmac=fadd42117ddd0daffd2e3b564aed50209b061edd15ce59d5f25ff711523a3db8"
            };
            genres.Add(genre);

            genre = new Genre()
            {
                Name = "Supernatural",
                ImageURL = "https://img.freepik.com/free-photo/doomsday-scene-catastrophe-digital-illustration_456031-51.jpg?w=1380&t=st=1690645557~exp=1690646157~hmac=d0399ce74558d886a183733b8b081a544752c4b62b9716931f35d7341fd0c0c2"
            };
            genres.Add(genre);

            genre = new Genre()
            {
                Name = "Sports",
                ImageURL = "https://img.freepik.com/free-photo/soccer-ball-white-line-stadium_1150-5285.jpg?w=996&t=st=1690645585~exp=1690646185~hmac=6116b95c4db3685731491d73b2eadef22128b617e906bbf22b1ef2f51b21bf2a"
            };
            genres.Add(genre);

            genre = new Genre()
            {
                Name = "Adventure",
                ImageURL = "https://img.freepik.com/free-photo/photographer-hand-holding-camera-standing-viewpoint-clouds-panorama-viewpoint-sunrise_335224-1320.jpg?w=996&t=st=1690645725~exp=1690646325~hmac=fe9c6f2d727ddfadff01addb7c94e2cccc477fed176a493c19a4c4875f079963"
            };
            genres.Add(genre);

            return genres.ToArray();
        }
    }
}
