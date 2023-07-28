using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MoviesWatchlist.Data.Models;
using System.Reflection;

namespace MoviesWatchlist.Data
{
    public class MoviesDbContext : IdentityDbContext<AppUser, IdentityRole<Guid>, Guid>
    {
        public MoviesDbContext(DbContextOptions<MoviesDbContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; } = null!;

        public DbSet<Actor> Actors { get; set; } = null!;

        public DbSet<MovieActor> MoviesActors { get; set; } = null!;

        public DbSet<Genre> Genres { get; set; } = null!;

        public DbSet<MovieGenre> MoviesGenres { get; set; } = null!;

        public DbSet<Writer> Writers { get; set; } = null!;

        public DbSet<MovieWriter> MoviesWriters { get; set; } = null!;

        public DbSet<Director> Directors { get; set; } = null!;

        public DbSet<IdentityUserMovie> IdentityUsersMovies { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            Assembly configAssembly = Assembly.GetAssembly(typeof(MoviesDbContext)) ?? Assembly.GetExecutingAssembly();

            builder.ApplyConfigurationsFromAssembly(configAssembly);

            builder.Entity<MovieActor>().HasKey(x => new { x.MovieId, x.ActorId });

            builder.Entity<MovieGenre>().HasKey(x => new { x.MovieId, x.GenreId });

            builder.Entity<MovieWriter>().HasKey(x => new { x.MovieId, x.WriterId });

            builder.Entity<IdentityUserMovie>().HasKey(x => new { x.MovieId, x.CollectorId });

            base.OnModelCreating(builder);
        }
    }
}