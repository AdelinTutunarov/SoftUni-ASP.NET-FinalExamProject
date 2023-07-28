using Microsoft.AspNetCore.Identity;

namespace MoviesWatchlist.Data.Models
{
    public class AppUser : IdentityUser<Guid>
    {
        public AppUser()
        {
            Id = Guid.NewGuid();
            IdentityUsersMovies = new HashSet<IdentityUserMovie>();
        }

        public ICollection<IdentityUserMovie> IdentityUsersMovies { get; set; }
    }
}
