using Microsoft.AspNetCore.Mvc;
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
        private readonly ILogger<HomeController> _logger;
        private MovieResponseContext blahContext { get; set; }

        public HomeController(ILogger<HomeController> logger, MovieResponseContext someName)
        {
            _logger = logger;
            blahContext = someName;
        }

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
            return View();
        }

        [HttpPost]
        public IActionResult Movies (MovieResponse mr)
        {
            if(ModelState.IsValid)
            {
                blahContext.Add(mr);
                blahContext.SaveChanges();
                return View("Confirmation", mr);
            }
            else
            {
                return View();
            }

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
