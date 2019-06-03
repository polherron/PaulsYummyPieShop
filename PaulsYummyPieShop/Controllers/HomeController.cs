using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PaulsYummyPieShop.Models;
using PaulsYummyPieShop.ViewModels;

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
            HomeViewModel myHomeViewModel = new HomeViewModel();
            myHomeViewModel.Title = "Paul's Pie Shop";
            myHomeViewModel.Pies = _pieRepository.GetAllPies().OrderBy(p => p.Name).ToList();
            return View(myHomeViewModel);
        }
    }
}
