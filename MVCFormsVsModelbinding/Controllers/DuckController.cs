using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCFormsVsModelbinding.Controllers
{
    public class DuckController : Controller
    {
        /// <summary>
        /// Adds a Duck object to the database
        /// </summary>
        /// <returns></returns>
        public IActionResult Add()
        {
            return View();
        }
    }
}
