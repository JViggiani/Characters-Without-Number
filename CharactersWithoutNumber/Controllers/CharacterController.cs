using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CharactersWithoutNumber.Models;

namespace CharactersWithoutNumber.Controllers
{
    public class CharacterController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewData["Message"] = "Character Sheet Placeholder.";

            return View();
        }

        public IActionResult Manual()
        {
            ViewData["Message"] = "Character Sheet Placeholder.";
            var myCharacter = new Character()
            {
                Id = 1,
                Name = "Josh",
                Species = "Human",
                Gender = "Male"
            };

            return View(myCharacter);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
