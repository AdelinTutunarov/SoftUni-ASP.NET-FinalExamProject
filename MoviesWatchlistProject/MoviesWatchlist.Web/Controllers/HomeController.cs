﻿using Microsoft.AspNetCore.Mvc;
using MoviesWatchlist.Web.ViewModels.Home;
using System.Diagnostics;

namespace MoviesWatchlist.Web.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController()
        {
            
        }

        public IActionResult Index()
        {
            return RedirectToAction("All", "Movie");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}