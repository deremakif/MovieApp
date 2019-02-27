using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieApp.MvcWebUI.Models;

namespace MovieApp.MvcWebUI.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List(int? id)
        {
            var movies = MovieRepository.Movies;

            if (id != null)
            {
                movies = movies.Where(i => i.CategoryId == id).ToList();
            }

            return View(movies);
        }
    }
}