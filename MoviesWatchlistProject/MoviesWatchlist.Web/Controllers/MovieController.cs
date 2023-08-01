using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MoviesWatchlist.Web.Controllers
{
	[Authorize]
	public class MovieController : Controller
	{
		[AllowAnonymous]
		public async Task<IActionResult> All()
		{
			return View();
		}
	}
}
