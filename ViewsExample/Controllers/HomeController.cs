using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ViewsExample.Models;

namespace ViewsExample.Controllers
{
    public class HomeController : Controller
    {
        [Route("home")]
        [Route("/")]
        public IActionResult Index()
        {
            ViewData["people"] = new List<Person>
{
        new Person
    {
        Name = "Raju",
        DateOfBirth = DateTime.Parse("2000-12-20").Date,
        PersonGender = Gender.Male
    },
    new Person
    {
        Name = "Seema",
        DateOfBirth = DateTime.Parse("1999-05-10"),
        PersonGender = Gender.Female
    },
    new Person
    {
        Name = "Alexa",
        DateOfBirth = DateTime.Parse("2001-03-15"),
        PersonGender = Gender.Other
    }

    };

            return View();
        }
    }
}
