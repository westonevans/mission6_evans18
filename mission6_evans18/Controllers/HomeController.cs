using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using mission6_evans18.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace mission6_evans18.Controllers
{
    public class HomeController : Controller
    {
        private MovieResponseContext mvContext { get; set; }

        public HomeController(MovieResponseContext someName)
        {
            mvContext = someName;
        }
        //comment

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Podcasts()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Movies()
        {
            ViewBag.Categories = mvContext.Categories.ToList();
            return View("Movies", new MovieResponse());
        }

        [HttpPost]
        public IActionResult Movies (MovieResponse mr)
        {
            ViewBag.Categories = mvContext.Categories.ToList();

            if (ModelState.IsValid)
            {
                mvContext.Add(mr);
                mvContext.SaveChanges();
                return View("Confirmation", mr);
            }
            else
            {
                return View();
            }
      
        }

        [HttpGet]
        public IActionResult ListMovies ()
        {
            var applications = mvContext.Responses
                .Include(x => x.Category)
                //.Where(blah => blah.LentTo == null)
                .OrderBy(x=> x.Category)
                .ToList();

            return View(applications);
        }

        [HttpGet]
        public IActionResult Edit (int id)
        {
            ViewBag.Categories = mvContext.Categories.ToList();

            var application = mvContext.Responses.Single(x => x.MovieID == id);

            return View("Movies", application);
        }

        [HttpPost]
        public IActionResult Edit(MovieResponse blah)
        {
            mvContext.Update(blah);
            mvContext.SaveChanges();

            return RedirectToAction("ListMovies");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var application = mvContext.Responses.Single(x => x.MovieID == id);
            return View(application);
        }

        [HttpPost]
        public IActionResult Delete(MovieResponse mr)
        {
            mvContext.Responses.Remove(mr);
            mvContext.SaveChanges();

            return RedirectToAction("ListMovies");
        }

    }
}
 