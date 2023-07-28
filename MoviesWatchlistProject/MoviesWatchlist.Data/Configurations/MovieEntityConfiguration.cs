using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MoviesWatchlist.Data.Models;

namespace MoviesWatchlist.Data.Configurations
{
    public class MovieEntityConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder
                .HasOne(m => m.Director)
                .WithMany(d => d.Movies)
                .HasForeignKey(m => m.DirectorId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(m => m.Rating).HasPrecision(18, 2);

            //builder.OwnsMany(m => m.MoviesActors);

            builder.HasData(GenerateMovies());
        }

        private Movie[] GenerateMovies()
        {
            ICollection<Movie> movies = new HashSet<Movie>();

            Movie movie;

            Guid id;

            //1
            id = Guid.NewGuid();
            movie = new Movie()
            {
                Id = id,
                Title = "Transformers",
                ReleaseYear = 2007,
                Rating = 7.00M,
                Description = "An ancient struggle between two Cybertronian races, " +
                "the heroic Autobots and the evil Decepticons, comes to Earth, " +
                "with a clue to the ultimate power held by a teenager.",
                ImageURL = "https://en.wikipedia.org/wiki/Transformers_(film)#/media/File:Transformers07.jpg",
                DirectorId = 1,
                MoviesWriters = new HashSet<MovieWriter>()
                {
                    new MovieWriter
                    {
                        WriterId = 1,
                        MovieId = id
                    },
                    new MovieWriter
                    {
                        WriterId = 2,
                        MovieId = id
                    },
                    new MovieWriter
                    {
                        WriterId = 3,
                        MovieId = id
                    }
                },
                MoviesActors = new HashSet<MovieActor>()
                {
                    new MovieActor
                    {
                        ActorId = 1,
                        MovieId = id
                    },
                    new MovieActor
                    {
                        ActorId = 2,
                        MovieId = id
                    },
                    new MovieActor
                    {
                        ActorId = 3,
                        MovieId = id
                    },
                    new MovieActor
                    {
                        ActorId = 4,
                        MovieId = id
                    },
                    new MovieActor
                    {
                        ActorId = 5,
                        MovieId = id
                    },
                    new MovieActor
                    {
                        ActorId = 6,
                        MovieId = id
                    }
                },
                MoviesGenres = new HashSet<MovieGenre>()
                {
                    new MovieGenre
                    {
                        GenreId = 1,
                        MovieId = id
                    },
                    new MovieGenre
                    {
                        GenreId = 14,
                        MovieId = id
                    },
                    new MovieGenre
                    {
                        GenreId = 18,
                        MovieId = id
                    }
                }
            };
            movies.Add(movie);

            //2
            id = Guid.NewGuid();
            movie = new Movie()
            {
                Id = id,
                Title = "Transformers: Revenge of the Fallen",
                ReleaseYear = 2009,
                Rating = 5.90M,
                Description = "Sam Witwicky leaves the Autobots behind for a normal life. " +
                "But when his mind is filled with cryptic symbols, " +
                "the Decepticons target him and he is dragged back into the Transformers' war.",
                ImageURL = "https://en.wikipedia.org/wiki/Transformers:_Revenge_of_the_Fallen#/media/File:TF2SteelPoster.jpg",
                DirectorId = 1,
                MoviesWriters = new HashSet<MovieWriter>()
                {
                    new MovieWriter
                    {
                        WriterId = 1,
                        MovieId = id
                    },
                    new MovieWriter
                    {
                        WriterId = 2,
                        MovieId = id
                    },
                    new MovieWriter
                    {
                        WriterId = 4,
                        MovieId = id
                    }
                },
                MoviesActors = new HashSet<MovieActor>()
                {
                    new MovieActor
                    {
                        ActorId = 2,
                        MovieId = id
                    },
                    new MovieActor
                    {
                        ActorId = 3,
                        MovieId = id
                    },
                    new MovieActor
                    {
                        ActorId = 4,
                        MovieId = id
                    },
                    new MovieActor
                    {
                        ActorId = 5,
                        MovieId = id
                    },
                    new MovieActor
                    {
                        ActorId = 6,
                        MovieId = id
                    }
                },
                MoviesGenres = new HashSet<MovieGenre>()
                {
                    new MovieGenre
                    {
                        GenreId = 1,
                        MovieId = id
                    },
                    new MovieGenre
                    {
                        GenreId = 14,
                        MovieId = id
                    },
                    new MovieGenre
                    {
                        GenreId = 18,
                        MovieId = id
                    }
                }
            };
            movies.Add(movie);

            //3
            id = Guid.NewGuid();
            movie = new Movie()
            {
                Id = id,
                Title = "Transformers: Dark of the Moon",
                ReleaseYear = 2011,
                Rating = 6.20M,
                Description = "The Autobots learn of a Cybertronian spacecraft hidden on the moon, " +
                "and race against the Decepticons to reach it and to learn its secrets.",
                ImageURL = "https://en.wikipedia.org/wiki/Transformers:_Dark_of_the_Moon#/media/File:Transformers_dark_of_the_moon_ver5.jpg",
                DirectorId = 1,
                MoviesWriters = new HashSet<MovieWriter>()
                {
                    new MovieWriter
                    {
                        WriterId = 4,
                        MovieId = id
                    }
                },
                MoviesActors = new HashSet<MovieActor>()
                {
                    new MovieActor
                    {
                        ActorId = 2,
                        MovieId = id
                    },
                    new MovieActor
                    {
                        ActorId = 4,
                        MovieId = id
                    },
                    new MovieActor
                    {
                        ActorId = 5,
                        MovieId = id
                    },
                    new MovieActor
                    {
                        ActorId = 6,
                        MovieId = id
                    }
                },
                MoviesGenres = new HashSet<MovieGenre>()
                {
                    new MovieGenre
                    {
                        GenreId = 1,
                        MovieId = id
                    },
                    new MovieGenre
                    {
                        GenreId = 14,
                        MovieId = id
                    },
                    new MovieGenre
                    {
                        GenreId = 18,
                        MovieId = id
                    }
                }
            };
            movies.Add(movie);

            //4
            id = Guid.NewGuid();
            movie = new Movie()
            {
                Id = id,
                Title = "Transformers: Age of Extinction",
                ReleaseYear = 2014,
                Rating = 5.60M,
                Description = "When humanity allies with a bounty hunter in pursuit of Optimus Prime, " +
                "the Autobots turn to a mechanic and his family for help.",
                ImageURL = "https://en.wikipedia.org/wiki/Transformers:_Age_of_Extinction#/media/File:Transformers_Age_of_Extinction_poster.jpg",
                DirectorId = 1,
                MoviesWriters = new HashSet<MovieWriter>()
                {
                    new MovieWriter
                    {
                        WriterId = 4,
                        MovieId = id
                    }
                },
                MoviesActors = new HashSet<MovieActor>()
                {
                    new MovieActor
                    {
                        ActorId = 7,
                        MovieId = id
                    },
                    new MovieActor
                    {
                        ActorId = 8,
                        MovieId = id
                    }
                },
                MoviesGenres = new HashSet<MovieGenre>()
                {
                    new MovieGenre
                    {
                        GenreId = 1,
                        MovieId = id
                    },
                    new MovieGenre
                    {
                        GenreId = 14,
                        MovieId = id
                    },
                    new MovieGenre
                    {
                        GenreId = 18,
                        MovieId = id
                    }
                }
            };
            movies.Add(movie);

            //5
            id = Guid.NewGuid();
            movie = new Movie()
            {
                Id = id,
                Title = "Transformers: The Last Knight",
                ReleaseYear = 2017,
                Rating = 5.20M,
                Description = "A deadly threat from Earth's history reappears and a hunt " +
                "for a lost artifact takes place between Autobots and Decepticons, while Optimus Prime " +
                "encounters his creator in space.",
                ImageURL = "https://en.wikipedia.org/wiki/Transformers:_The_Last_Knight#/media/File:Transformers_The_Last_Knight_poster.jpg",
                DirectorId = 1,
                MoviesWriters = new HashSet<MovieWriter>()
                {
                    new MovieWriter
                    {
                        WriterId = 5,
                        MovieId = id
                    },
                    new MovieWriter
                    {
                        WriterId = 6,
                        MovieId = id
                    },
                    new MovieWriter
                    {
                        WriterId = 7,
                        MovieId = id
                    }
                },
                MoviesActors = new HashSet<MovieActor>()
                {
                    new MovieActor
                    {
                        ActorId = 7,
                        MovieId = id
                    },
                    new MovieActor
                    {
                        ActorId = 8,
                        MovieId = id
                    },
                    new MovieActor
                    {
                        ActorId = 9,
                        MovieId = id
                    },
                    new MovieActor
                    {
                        ActorId = 5,
                        MovieId = id
                    }
                },
                MoviesGenres = new HashSet<MovieGenre>()
                {
                    new MovieGenre
                    {
                        GenreId = 1,
                        MovieId = id
                    },
                    new MovieGenre
                    {
                        GenreId = 14,
                        MovieId = id
                    },
                    new MovieGenre
                    {
                        GenreId = 18,
                        MovieId = id
                    }
                }
            };
            movies.Add(movie);

            //6
            id = Guid.NewGuid();
            movie = new Movie()
            {
                Id = id,
                Title = "Bumblebee",
                ReleaseYear = 2018,
                Rating = 6.70M,
                Description = "On the run in the year 1987, " +
                "Bumblebee finds refuge in a junkyard in a small California beach town. " +
                "On the cusp of turning 18 and trying to find her place in the world, " +
                "Charlie Watson discovers Bumblebee, battle-scarred and broken.",
                ImageURL = "https://en.wikipedia.org/wiki/Bumblebee_(film)#/media/File:Bumblebee_(film)_poster.png",
                DirectorId = 2,
                MoviesWriters = new HashSet<MovieWriter>()
                {
                    new MovieWriter
                    {
                        WriterId = 8,
                        MovieId = id
                    }
                },
                MoviesActors = new HashSet<MovieActor>()
                {
                    new MovieActor
                    {
                        ActorId = 10,
                        MovieId = id
                    },
                    new MovieActor
                    {
                        ActorId = 11,
                        MovieId = id
                    },
                    new MovieActor
                    {
                        ActorId = 12,
                        MovieId = id
                    }
                },
                MoviesGenres = new HashSet<MovieGenre>()
                {
                    new MovieGenre
                    {
                        GenreId = 1,
                        MovieId = id
                    },
                    new MovieGenre
                    {
                        GenreId = 14,
                        MovieId = id
                    },
                    new MovieGenre
                    {
                        GenreId = 18,
                        MovieId = id
                    }
                }
            };
            movies.Add(movie);

            //7
            id = Guid.NewGuid();
            movie = new Movie()
            {
                Id = id,
                Title = "Transformers: Rise of the Beasts",
                ReleaseYear = 2023,
                Rating = 6.20M,
                Description = "During the '90s, a new faction of Transformers - the Maximals - join " +
                "the Autobots as allies in the battle for Earth.",
                ImageURL = "https://en.wikipedia.org/wiki/Transformers:_Rise_of_the_Beasts#/media/File:Transformers-_Rise_of_the_Beasts.jpg",
                DirectorId = 3,
                MoviesWriters = new HashSet<MovieWriter>()
                {
                    new MovieWriter
                    {
                        WriterId = 17,
                        MovieId = id
                    }
                },
                MoviesActors = new HashSet<MovieActor>()
                {
                    new MovieActor
                    {
                        ActorId = 13,
                        MovieId = id
                    },
                    new MovieActor
                    {
                        ActorId = 14,
                        MovieId = id
                    },
                },
                MoviesGenres = new HashSet<MovieGenre>()
                {
                    new MovieGenre
                    {
                        GenreId = 1,
                        MovieId = id
                    },
                    new MovieGenre
                    {
                        GenreId = 14,
                        MovieId = id
                    },
                    new MovieGenre
                    {
                        GenreId = 18,
                        MovieId = id
                    }
                }
            };
            movies.Add(movie);

            //8
            id = Guid.NewGuid();
            movie = new Movie()
            {
                Id = id,
                Title = "Iron Man",
                ReleaseYear = 2008,
                Rating = 7.90M,
                Description = "After being held captive in an Afghan cave, billionaire engineer " +
                "Tony Stark creates a unique weaponized suit of armor to fight evil.",
                ImageURL = "https://en.wikipedia.org/wiki/Iron_Man_(2008_film)#/media/File:Iron_Man_(2008_film)_poster.jpg",
                DirectorId = 4,
                MoviesWriters = new HashSet<MovieWriter>()
                {
                    new MovieWriter
                    {
                        WriterId = 9,
                        MovieId = id
                    },
                    new MovieWriter
                    {
                        WriterId = 10,
                        MovieId = id
                    },
                    new MovieWriter
                    {
                        WriterId = 6,
                        MovieId = id
                    },
                    new MovieWriter
                    {
                        WriterId = 7,
                        MovieId = id
                    }
                },
                MoviesActors = new HashSet<MovieActor>()
                {
                    new MovieActor
                    {
                        ActorId = 15,
                        MovieId = id
                    },
                    new MovieActor
                    {
                        ActorId = 16,
                        MovieId = id
                    },
                    new MovieActor
                    {
                        ActorId = 17,
                        MovieId = id
                    }
                },
                MoviesGenres = new HashSet<MovieGenre>()
                {
                    new MovieGenre
                    {
                        GenreId = 1,
                        MovieId = id
                    },
                    new MovieGenre
                    {
                        GenreId = 14,
                        MovieId = id
                    },
                    new MovieGenre
                    {
                        GenreId = 18,
                        MovieId = id
                    }
                }
            };
            movies.Add(movie);

            //9
            id = Guid.NewGuid();
            movie = new Movie()
            {
                Id = id,
                Title = "Iron Man 2",
                ReleaseYear = 2010,
                Rating = 6.90M,
                Description = "With the world now aware of his identity as Iron Man, Tony Stark must " +
                "contend with both his declining health and a vengeful mad man with ties to his father's legacy.",
                ImageURL = "https://en.wikipedia.org/wiki/Iron_Man_2#/media/File:Iron_Man_2_poster.jpg",
                DirectorId = 4,
                MoviesWriters = new HashSet<MovieWriter>()
                {
                    new MovieWriter
                    {
                        WriterId = 11,
                        MovieId = id
                    }
                },
                MoviesActors = new HashSet<MovieActor>()
                {
                    new MovieActor
                    {
                        ActorId = 15,
                        MovieId = id
                    },
                    new MovieActor
                    {
                        ActorId = 17,
                        MovieId = id
                    },
                    new MovieActor
                    {
                        ActorId = 18,
                        MovieId = id
                    },
                    new MovieActor
                    {
                        ActorId = 19,
                        MovieId = id
                    }
                },
                MoviesGenres = new HashSet<MovieGenre>()
                {
                    new MovieGenre
                    {
                        GenreId = 1,
                        MovieId = id
                    },
                    new MovieGenre
                    {
                        GenreId = 14,
                        MovieId = id
                    }
                }
            };
            movies.Add(movie);

            //10
            id = Guid.NewGuid();
            movie = new Movie()
            {
                Id = id,
                Title = "Spider-Man: Homecoming",
                ReleaseYear = 2017,
                Rating = 7.40M,
                Description = "Peter Parker balances his life as an ordinary high school student in Queens " +
                "with his superhero alter-ego Spider-Man, and finds himself on the trail of a new menace prowling the skies of New York City.",
                ImageURL = "https://en.wikipedia.org/wiki/Spider-Man:_Homecoming#/media/File:Spider-Man_Homecoming_poster.jpg",
                DirectorId = 5,
                MoviesWriters = new HashSet<MovieWriter>()
                {
                    new MovieWriter
                    {
                        WriterId = 14,
                        MovieId = id
                    },
                    new MovieWriter
                    {
                        WriterId = 15,
                        MovieId = id
                    },
                    new MovieWriter
                    {
                        WriterId = 16,
                        MovieId = id
                    },
                    new MovieWriter
                    {
                        WriterId = 12,
                        MovieId = id
                    },
                    new MovieWriter
                    {
                        WriterId = 13,
                        MovieId = id
                    }
                },
                MoviesActors = new HashSet<MovieActor>()
                {
                    new MovieActor
                    {
                        ActorId = 20,
                        MovieId = id
                    },
                    new MovieActor
                    {
                        ActorId = 21,
                        MovieId = id
                    },
                    new MovieActor
                    {
                        ActorId = 17,
                        MovieId = id
                    },
                    new MovieActor
                    {
                        ActorId = 22,
                        MovieId = id
                    },
                    new MovieActor
                    {
                        ActorId = 23,
                        MovieId = id
                    },
                    new MovieActor
                    {
                        ActorId = 15,
                        MovieId = id
                    }
                },
                MoviesGenres = new HashSet<MovieGenre>()
                {
                    new MovieGenre
                    {
                        GenreId = 1,
                        MovieId = id
                    },
                    new MovieGenre
                    {
                        GenreId = 14,
                        MovieId = id
                    },
                    new MovieGenre
                    {
                        GenreId = 18,
                        MovieId = id
                    }
                }
            };
            movies.Add(movie);

            //11
            id = Guid.NewGuid();
            movie = new Movie()
            {
                Id = id,
                Title = "Spider-Man: Far From Home",
                ReleaseYear = 2019,
                Rating = 7.40M,
                Description = "Following the events of Avengers: Endgame (2019), Spider-Man must step up " +
                "to take on new threats in a world that has changed forever",
                ImageURL = "https://en.wikipedia.org/wiki/Spider-Man:_Far_From_Home#/media/File:Spider-Man_Far_From_Home_poster.jpg",
                DirectorId = 5,
                MoviesWriters = new HashSet<MovieWriter>()
                {
                    new MovieWriter
                    {
                        WriterId = 12,
                        MovieId = id
                    },
                    new MovieWriter
                    {
                        WriterId = 13,
                        MovieId = id
                    }
                },
                MoviesActors = new HashSet<MovieActor>()
                {
                    new MovieActor
                    {
                        ActorId = 20,
                        MovieId = id
                    },
                    new MovieActor
                    {
                        ActorId = 19,
                        MovieId = id
                    },
                    new MovieActor
                    {
                        ActorId = 22,
                        MovieId = id
                    },
                    new MovieActor
                    {
                        ActorId = 23,
                        MovieId = id
                    }
                },
                MoviesGenres = new HashSet<MovieGenre>()
                {
                    new MovieGenre
                    {
                        GenreId = 1,
                        MovieId = id
                    },
                    new MovieGenre
                    {
                        GenreId = 2,
                        MovieId = id
                    },
                    new MovieGenre
                    {
                        GenreId = 18,
                        MovieId = id
                    }
                }
            };
            movies.Add(movie);

            return movies.ToArray();
        }
    }
}
