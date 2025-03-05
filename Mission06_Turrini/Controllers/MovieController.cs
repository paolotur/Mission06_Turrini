using JoelHiltonFilmCollection.Data; 
using JoelHiltonFilmCollection.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace JoelHiltonFilmCollection.Controllers
{
    public class MovieController : Controller
    {
        private readonly AppDbContext _context;

        public MovieController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult List()
        {
            var movies = _context.Movies.ToList();
            return View(movies);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _context.Movies.Add(movie);
                _context.SaveChanges();
                return RedirectToAction("List");
            }
            return View(movie);
        }
    }
}
