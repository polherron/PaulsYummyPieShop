using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PaulsYummyPieShop.Models;

namespace PaulsYummyPieShop.Controllers
{

    public class HomeController : Controller
    {
        private readonly IPieRepository _pieRepository;

        //Within the constructor, dependency injection is used
        // to instantiate the pieRepository object
        public HomeController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }

        //Get: /Controller
        public IActionResult Index()
        {
            ViewBag.Title = "Pie overview";
            return View();
        }
    }
}
