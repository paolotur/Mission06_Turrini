using JoelHiltonFilmCollection.Data;
using JoelHiltonFilmCollection.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace JoelHiltonFilmCollection.Controllers
{
    public class MovieController : Controller
    {
        private readonly AppDbContext _context; // ✅ Correct context type

        public MovieController(AppDbContext context)
        {
            _context = context;
        }

        // Display List of Movies
        public IActionResult List()
        {
            var movies = _context.Movies.ToList();
            if (movies == null || !movies.Any())
            {
                ViewBag.Message = "No movies found in the database.";
            }
            return View(movies);
        }

        // Add a New Movie
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

        // Edit a Movie (GET)
        public IActionResult Edit(int id)
        {
            var movie = _context.Movies.Find(id);
            if (movie == null)
            {
                return NotFound();
            }
            return View(movie);
        }

        // Edit a Movie (POST)
        [HttpPost]
        public IActionResult Edit(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _context.Movies.Update(movie);
                _context.SaveChanges();
                return RedirectToAction("List");
            }
            return View(movie);
        }

        // Delete a Movie
        public IActionResult Delete(int id)
        {
            var movie = _context.Movies.Find(id);
            if (movie != null)
            {
                _context.Movies.Remove(movie);
                _context.SaveChanges();
            }
            return RedirectToAction("List");
        }
    }
}
