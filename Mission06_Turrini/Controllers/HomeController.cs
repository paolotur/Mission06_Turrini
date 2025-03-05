using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission06_Turrini.Models;
using Microsoft.AspNetCore.Mvc;

namespace JoelHiltonFilmCollection.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetToKnowJoel()
        {
            return View();
        }
    }
}
