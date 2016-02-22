using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using MVAMVC.Models;
using Microsoft.Extensions.OptionsModel;

namespace MVAMVC.Controllers
{
    public class HomeController : Controller
    {
        public HomeController( IOptions<MyOptions> o )
        {
            var controllerColor = o.Value.Color;
            var controllerWelcomeString = o.Value.WelcomeString;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Foo()
        {
            return View();
        }

        // GET /HOME/ABOUT
        [HttpGet]
        public IActionResult About()
        {
            ViewData["Message"] = "I am the home controller.";
            ViewData["FooMessage"] = "This is custom Foo Message";
            ViewData["FooCite"] = "http://meessitethis.bitchn";

            var p = new Person()
            {
                FirstName = "The First Name",
                LastName = "The Last Name",
                Birthday = new DateTime(1909, 1, 23)
            };

            return View(p);
        }

        //POST /HOME/ABOUT
        [HttpPost]
        public IActionResult About(Person person)
        {

            return View(person);
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
