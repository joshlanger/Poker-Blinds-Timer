using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BlindsTimer.Models;

namespace BlindsTimer.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult BlindConfiguration(Tournament tournament)
        {
            
            return View(tournament);
        }

        public IActionResult Play (Tournament tournament)
        {
            if(tournament.NumberOfLevels == 0)
            {
                tournament.BlindStructure = tournament.DefaultStructure;
            }
            return View(tournament);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
