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
            List<Person> person = new List<Person>
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
        DateOfBirth = null, //DateTime.Parse("1999-05-10"),
        PersonGender = Gender.Female
    },
    new Person
    {
        Name = "Alexa",
        DateOfBirth = DateTime.Parse("2001-03-15"),
        PersonGender = Gender.Other
    }

    };

            return View(person);
        }

        /// <summary>
        /// Returns the details of a person based on the provided name.
        /// </summary>
        /// <remarks>The method searches a predefined list of persons and returns the details of the first
        /// person whose name matches the provided name.</remarks>
        /// <param name="name">The name of the person whose details are to be retrieved. This parameter is optional and can be null.</param>
        /// <returns>An <see cref="IActionResult"/> that renders a view displaying the details of the matching person. If no
        /// person matches the provided name, the view will display null.</returns>

        [Route("person-details/{name}")]
        public IActionResult PersonDetails(string? name)
        {

            List<Person> person = new List<Person>
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
        DateOfBirth = null, //DateTime.Parse("1999-05-10"),
        PersonGender = Gender.Female
    },
    new Person
    {
        Name = "Alexa",
        DateOfBirth = DateTime.Parse("2001-03-15"),
        PersonGender = Gender.Other
    }

    };

            Person? MatchingPerson = person.Where(p => p.Name == name).FirstOrDefault();

            return View(MatchingPerson);
        }
        [Route("/Person-with-product")]
        public IActionResult PersonWithProduct()
        {
            Person person = new Person
            {
                Name = "Raju",
                DateOfBirth = Convert.ToDateTime("2000-12-20"),
                PersonGender = Gender.Male
            };
            Product product = new Product
            {
                ProductId = 1,
                ProductName = "Laptop"
            };

            PersonAndProductWrapperModel personAndProductWrapperModel = new PersonAndProductWrapperModel
            {
                PersonData = person,
                ProductData = product
            };

            return View(personAndProductWrapperModel);
        }
    }
}
