using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCFormsVsModelbinding.Models;

namespace MVCFormsVsModelbinding.Controllers
{
    public class DuckController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(IFormCollection form)
        {
            // Instantiate a new Duck object:
            Duck du = new Duck();

            // Populate each Duck property:
            du.Name = form["name"];
            du.Color = form["color"];
            du.CatchPhrase = form["catchphrase"];

            // Add to database

            ViewData["Added"] = du.Name + "was added with an ID of 8008";

            return View();
        }
    }
}
