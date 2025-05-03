using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //Jen pro testování a pochopení, jak funguje model MVC a mapování URL

        /// <summary>
        /// Metoda Index je výchozí metoda, která se volá, když je řadič volán bez konkrétní akce.
        /// </summary>
        /// <returns>řetězec</returns>
        //public string Index()
        //{
        //    return "Tohle je výchozí akce...";
        //}

        //public string Welcome(string name, int ID = 1)
        //{
        //    return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        //}

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }
    }
}
