using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Assignment42.Models;

namespace Assignment42.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<string> restrauntList = new List<string>();
            foreach(Restraunt r in Restraunt.GetRestraunts())
            {
                restrauntList.Add(string.Format("#{0}: {1} Dish: {2}  Address: {3} Phone {4} Website{5}", r.Rank, r.Restraunt_Name, r.Favorite_Dish, r.Address, r.Phone, r.Website));
            }

            return View(restrauntList);
        }
        [HttpGet]
        public IActionResult NewSuggestion()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewSuggestion(NewSuggestion newSuggestion)
        {
            TempStorage.AddSuggestion(newSuggestion);
            return View("ListSuggestions", newSuggestion);
        }

        public IActionResult ListSuggestions()
        {
            return View(TempStorage.Suggestions);
        }

        public IActionResult Home()
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
