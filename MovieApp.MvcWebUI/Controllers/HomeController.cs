using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieApp.MvcWebUI.Models;

namespace MovieApp.MvcWebUI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(MovieRepository.Movies);
        }

        public IActionResult Details(int id)
        {
            return View(MovieRepository.Movies.FirstOrDefault(i => i.Id == id));
        }
    }
}