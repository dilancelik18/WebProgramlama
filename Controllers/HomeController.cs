using Microsoft.AspNetCore.Mvc;
using RentCar.Models;
using System.Diagnostics;

namespace RentCar.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

     
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Hakkimizda()
        {
            return View();
        }

    }
}