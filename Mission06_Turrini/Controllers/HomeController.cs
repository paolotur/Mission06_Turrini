using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

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
