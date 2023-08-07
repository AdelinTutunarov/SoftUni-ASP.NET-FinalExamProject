using Microsoft.EntityFrameworkCore;
using MoviesWatchlist.Data;
using MoviesWatchlist.Data.Models;
using MoviesWatchlist.Services.Data.Interfaces;
using MoviesWatchList.Web.Infrastructure.Extensions;
using MoviesWatchList.Web.Infrastructure.ModelBinders;

namespace MoviesWatchlist.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

            builder.Services.AddDbContext<MoviesDbContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });

            builder.Services.AddDefaultIdentity<AppUser>(options => 
            {
                options.SignIn.RequireConfirmedAccount = builder.Configuration.GetValue<bool>("Identity:SignIn:RequireConfirmedAccount");
                options.Password.RequireNonAlphanumeric = builder.Configuration.GetValue<bool>("Identity:Password:RequireNonAlphanumeric");
                options.Password.RequireLowercase = builder.Configuration.GetValue<bool>("Identity:Password:RequireLowercase");
                options.Password.RequireUppercase = builder.Configuration.GetValue<bool>("Identity:Password:RequireUppercase");
                options.Password.RequiredLength = builder.Configuration.GetValue<int>("Identity:Password:RequiredLength");
            }).AddEntityFrameworkStores<MoviesDbContext>();

            builder.Services.AddAppServices(typeof(IMovieService));

            builder.Services.AddControllersWithViews().AddMvcOptions(oprions =>
            {
                oprions.ModelBinderProviders.Insert(0, new DecimalModelBinderProvider());
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapDefaultControllerRoute();
            app.MapRazorPages();

            app.Run();
        }
    }
}