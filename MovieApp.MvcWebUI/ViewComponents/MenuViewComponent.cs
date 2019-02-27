using Microsoft.AspNetCore.Mvc;
using MovieApp.MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.MvcWebUI.ViewComponents
{
    public class MenuViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["id"];
            return View(CategoryRepository.Categories);
        }
    }
}
