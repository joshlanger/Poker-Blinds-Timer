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
            //Tournament Default = new Tournament();
            //Dictionary<int, Level> DefaultStructure = new Dictionary<int, Level>();
            //Default.BlindStructure = Default.SetDefaultBlindStructure();
            return View();
        }

        public IActionResult SetDefault()
        {
            Tournament Tournament = new Tournament();
            
            Tournament.BlindStructure = Tournament.BlindStructureLoader();
            Tournament.LevelMinutes = 15;
            return RedirectToAction("Play", Tournament);
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
