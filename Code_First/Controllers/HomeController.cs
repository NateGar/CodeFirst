using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Code_First.Models;
using Code_First.Context;

namespace Code_First.Controllers
{
    public class HomeController : Controller
    {
        private readonly ThingContext _context;

        public HomeController(ThingContext _context)
        {
            this._context = _context;
        }

        public IActionResult Index()
        {
            List<Thing> Things = _context.Things.ToList();
            return View(Things);
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
