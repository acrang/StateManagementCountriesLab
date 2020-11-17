using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StateManagementCountriesLab.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace StateManagementCountriesLab.Controllers
{

    public class HomeController : Controller
    {
        public List<Country> CountriesList { get; set; }

        public HomeController()
        {
            CountriesList = new List<Country>
            {
                new Country("Finland,", "Finnish", "Tervetuloa", "Cold and fond of vodka", "Blue, White"),
                new Country("Russia", "Russian", "Привет", "Even colder and even more fond of vodka", "White", "Blue", "Red"),
                new Country("Mauritania", "Arabic", "Salamo Alaykom", "Hot 'n humid", "Green", "Yellow", "Red"),
                new Country("Canada", "English", "Oh you betcha, eh", "Friendly and love Tim Hortons", "Red", "White"),
                new Country("Sealand", "English", "Why did you come here", "Exists in the ocean on an offshore oil platform for some reason", "Red", "White", "Black")
            };
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DisplayDetails(int country)
        {
            TempData["SelectedCountry"] = CountriesList[country];            

            return View();
        }

        public IActionResult DisplayDescription(int country)
        {
            TempData["SelectedCountry"] = CountriesList[country];

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
